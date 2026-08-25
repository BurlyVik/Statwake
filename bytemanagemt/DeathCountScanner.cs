namespace edcs_edlen_death_counter_service
{
    public class DeathCountScanner
    {
        private const int PatternLength = 12;

        private const int Marker1 =
            unchecked((int)0xFFFFFFFF);

        private const int Marker2 =
            0x00000800;

        public DeathSearchResult Find(
            byte[] data,
            int offset,
            int length)
        {
            if (!BinaryReaderHelper.IsRangeValid(
                    data,
                    offset,
                    length))
            {
                return null;
            }
            if (length < PatternLength)
            {
                return null;
            }
            int end =
                offset +
                length -
                PatternLength;
            for (int position = offset;
                 position <= end;
                 position++)
            {
                int possibleDeathCount =
                    BinaryReaderHelper.ReadInt32LE(
                        data,
                        position);
                int marker1 =
                    BinaryReaderHelper.ReadInt32LE(
                        data,
                        position + 4);
                int marker2 =
                    BinaryReaderHelper.ReadInt32LE(
                        data,
                        position + 8);
                if (marker1 == Marker1 &&
                    marker2 == Marker2 &&
                    possibleDeathCount >= 0)
                {
                    return new DeathSearchResult(
                        value:
                            possibleDeathCount,
                        globalOffset:
                            position,
                        blockOffset:
                            position - offset);
                }
            }
            return null;
        }
    }
}
