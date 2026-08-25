namespace edcs_edlen_death_counter_service
{
    public class CharacterName : SaveField
    {
        public string Text => (string)Value;

        public CharacterName(
            string value,
            long globalOffset,
            int blockOffset,
            string block)
            : base(
                name: "Character Name",
                value: value,
                globalOffset: globalOffset,
                blockOffset: blockOffset,
                block: block,
                byteSize: SaveLayout.CharacterNameLength,
                bitWidth: SaveLayout.CharacterNameLength * 8,
                dataType: "String (UTF-16LE)",
                detectionMethod: "Fixed offset")
        {
        }
    }
}
