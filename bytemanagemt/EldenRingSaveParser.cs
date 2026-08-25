using System;
using System.Collections.Generic;
using System.IO;
namespace edcs_edlen_death_counter_service
{
    public class EldenRingSaveParser
    {
        private readonly DeathCountScanner _deathCountScanner;

        public EldenRingSaveParser()
        {
            _deathCountScanner =
                new DeathCountScanner();
        }
        public List<SaveProfile> ExtractProfiles(
            string saveFile)
        {
            if (!File.Exists(saveFile))
            {
                throw new FileNotFoundException(
                    "Save file was not found.",
                    saveFile);
            }
            byte[] fileData =
                File.ReadAllBytes(
                    saveFile);
            List<SaveProfile> profiles =
                new List<SaveProfile>(
                    SaveLayout.NumberOfSlots);

            for (int slotIndex = 0;
                 slotIndex < SaveLayout.NumberOfSlots;
                 slotIndex++)
            {
                SaveProfile profile =
                    ReadSlot(
                        fileData,
                        slotIndex);
                if (profile != null)
                {
                    profiles.Add(profile);
                }
            }
            return profiles;
        }
        private SaveProfile ReadSlot(
            byte[] fileData,
            int slotIndex)
        {
            int slotOffset =
                GetSlotOffset(
                    slotIndex);
            int headerOffset =
                GetHeaderOffset(
                    slotIndex);
            if (!IsSlotInBounds(
                    fileData,
                    slotOffset,
                    headerOffset))
            {
                return null;
            }
            byte[] slotData =
                CopySlotData(
                    fileData,
                    slotOffset);
            bool isActive =
                IsSlotActive(
                    fileData,
                    slotIndex);

            SaveProfile profile =
                new SaveProfile(
                    slotIndex,
                    isActive,
                    isActive
                        ? slotData
                        : null);

            if (!isActive)
            {
                return profile;
            }
            ReadCharacterName(
                fileData,
                profile,
                headerOffset,
                slotIndex);

            ReadCharacterLevel(
                fileData,
                profile,
                headerOffset,
                slotIndex);

            ReadPlaytime(
                fileData,
                profile,
                headerOffset,
                slotIndex);

            ReadDeathCount(
                fileData,
                profile,
                slotOffset,
                headerOffset,
                slotIndex);

            return profile;
        }

        private static int GetSlotOffset(
            int slotIndex)
        {
            return
                SaveLayout.SlotStartIndex +
                (slotIndex *
                 SaveLayout.SlotLength);
        }

        private static int GetHeaderOffset(
            int slotIndex)
        {
            return
                SaveLayout.SaveHeaderStartIndex +
                (slotIndex *
                 SaveLayout.SaveHeaderLength);
        }

        private static bool IsSlotInBounds(
            byte[] data,
            int slotOffset,
            int headerOffset)
        {
            bool slotValid =
                BinaryReaderHelper.IsRangeValid(
                    data,
                    slotOffset,
                    SaveLayout.SlotLength);

            bool headerValid =
                BinaryReaderHelper.IsRangeValid(
                    data,
                    headerOffset,
                    SaveLayout.SaveHeaderLength);

            return
                slotValid &&
                headerValid;
        }

        private static byte[] CopySlotData(
            byte[] fileData,
            int slotOffset)
        {
            byte[] slotData =
                new byte[
                    SaveLayout.SlotLength];

            Array.Copy(
                fileData,
                slotOffset,
                slotData,
                0,
                SaveLayout.SlotLength);

            return slotData;
        }

        private static bool IsSlotActive(
            byte[] fileData,
            int slotIndex)
        {
            int activeOffset =
                SaveLayout.CharacterActiveStatusStartIndex +
                slotIndex;

            if (!BinaryReaderHelper.IsRangeValid(
                    fileData,
                    activeOffset,
                    1))
            {
                return false;
            }

            return
                fileData[activeOffset] == 1;
        }

        private static void ReadCharacterName(
            byte[] data,
            SaveProfile profile,
            int headerOffset,
            int slotIndex)
        {
            string value =
                BinaryReaderHelper.ReadUtf16LeString(
                    data,
                    headerOffset,
                    SaveLayout.CharacterNameLength);

            profile.Name =
                new CharacterName(
                    value:
                        value,
                    globalOffset:
                        headerOffset,
                    blockOffset:
                        0x00,
                    block:
                        $"Character Metadata Slot {slotIndex}");
        }

        private static void ReadCharacterLevel(
            byte[] data,
            SaveProfile profile,
            int headerOffset,
            int slotIndex)
        {
            int offset =
                headerOffset +
                SaveLayout.CharacterLevelOffset;

            int value =
                BinaryReaderHelper.ReadUInt16LE(
                    data,
                    offset);

            profile.Level =
                new CharacterLevel(
                    value:
                        value,
                    globalOffset:
                        offset,
                    blockOffset:
                        SaveLayout.CharacterLevelOffset,
                    block:
                        $"Character Metadata Slot {slotIndex}");
        }

        private static void ReadPlaytime(
            byte[] data,
            SaveProfile profile,
            int headerOffset,
            int slotIndex)
        {
            int offset =
                headerOffset +
                SaveLayout.CharacterPlaytimeOffset;

            long value =
                BinaryReaderHelper.ReadUInt32LE(
                    data,
                    offset);

            profile.Playtime =
                new Playtime(
                    value:
                        value,
                    globalOffset:
                        offset,
                    blockOffset:
                        SaveLayout.CharacterPlaytimeOffset,
                    block:
                        $"Character Metadata Slot {slotIndex}");
        }

        private void ReadDeathCount(
            byte[] data,
            SaveProfile profile,
            int slotOffset,
            int headerOffset,
            int slotIndex)
        {
            DeathSearchResult death =
                _deathCountScanner.Find(
                    data,
                    slotOffset,
                    SaveLayout.SlotLength);

            string block =
                $"Character Save Slot {slotIndex}";

            if (death == null)
            {
                profile.DeathCount =
                    DeathCount.NotFound(
                        block);
                profile.ProfileLength = -1;
                return;
            }

            profile.DeathCount =
                new DeathCount(
                    value:
                        death.Value,
                    globalOffset:
                        death.GlobalOffset,
                    blockOffset:
                        death.GlobalOffset -
                        headerOffset,
                    block:
                        block,
                    detectionMethod:
                        "Pattern scan: " +
                        "[DeathCount][FFFFFFFF][00000800]");

            // ------------------------------------------------------------
            // Profile length
            //
            // IMPOTRTANT:
            //
            // Name is the beginning.
            // Death Count is the endpoint.
            //
            // ProfileLength =
            //     DeathCount.GlobalOffset -
            //     Name.GlobalOffset
            //
            // ------------------------------------------------------------
            profile.ProfileLength =
                death.GlobalOffset -
                headerOffset;
        }
    }
}
