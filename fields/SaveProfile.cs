namespace edcs_edlen_death_counter_service
{

    public class SaveProfile
    {
        public int SlotIndex { get; }
        public bool IsActive { get; }
        public CharacterName Name { get; set; }
        public CharacterLevel Level { get; set; }
        public Playtime Playtime { get; set; }
        public DeathCount DeathCount { get; set; }

        // Distance from the beginning of the Name
        // block to the Death Count.
        public long ProfileLength { get; set; }

        public SaveProfile(
            int slotIndex,
            bool isActive,
            byte[] slotData)
        {
            SlotIndex = slotIndex;
            IsActive = isActive;
            ProfileLength = -1;
        }
    }
}
