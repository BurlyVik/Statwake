namespace edcs_edlen_death_counter_service
{
    public class CharacterLevel : SaveField
    {
        public int ValueInt => (int)Value;

        public CharacterLevel(
            int value,
            long globalOffset,
            int blockOffset,
            string block)
            : base(
                name: "Character Level",
                value: value,
                globalOffset: globalOffset,
                blockOffset: blockOffset,
                block: block,
                byteSize: 2,
                bitWidth: 16,
                dataType: "UInt16",
                detectionMethod: "Fixed offset")
        {
        }
    }
}
