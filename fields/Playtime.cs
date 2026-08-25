namespace edcs_edlen_death_counter_service
{
    public class Playtime : SaveField
    {
        public long Seconds => (long)Value;

        public Playtime(
            long value,
            long globalOffset,
            int blockOffset,
            string block)
            : base(
                name: "Playtime",
                value: value,
                globalOffset: globalOffset,
                blockOffset: blockOffset,
                block: block,
                byteSize: 4,
                bitWidth: 32,
                dataType: "UInt32",
                detectionMethod: "Fixed offset")
        {
        }
    }
}
