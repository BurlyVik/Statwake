namespace edcs_edlen_death_counter_service
{

    public class DeathCount : SaveField
    {
        public int Count => (int)Value;

        public bool Found =>
            GlobalOffset >= 0;

        public DeathCount(
            int value,
            long globalOffset,
            int blockOffset,
            string block,
            string detectionMethod)
            : base(
                name: "Death Count",
                value: value,
                globalOffset: globalOffset,
                blockOffset: blockOffset,
                block: block,
                byteSize: 4,
                bitWidth: 32,
                dataType: "Int32",
                detectionMethod: detectionMethod)
        {
        }

        public static DeathCount NotFound(string block)
        {
            return new DeathCount(
                value: -1,
                globalOffset: -1,
                blockOffset: -1,
                block: block,
                detectionMethod: "Pattern not found");
        }
    }
}
