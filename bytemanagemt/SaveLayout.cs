namespace edcs_edlen_death_counter_service
{
    public static class SaveLayout
    {
        public const int SlotStartIndex =
            0x310;
        public const int SlotLength =
            0x280000;
        public const int NumberOfSlots =
            10;
        public const int SaveHeaderLength =
            0x24C;
        public const int SaveHeaderStartIndex =
            0x1901D0E;
        public const int CharacterActiveStatusStartIndex =
            0x1901D04;
        public const int CharacterNameLength =
            0x22;
        public const int CharacterLevelOffset =
            0x22;
        public const int CharacterPlaytimeOffset =
            0x26;
    }
}
