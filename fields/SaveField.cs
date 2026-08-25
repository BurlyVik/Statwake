namespace edcs_edlen_death_counter_service
{

    public abstract class SaveField
    {
        public string Name { get; protected set; }
        public object Value { get; protected set; }
        public long GlobalOffset { get; protected set; }
        public int BlockOffset { get; protected set; }
        public string Block { get; protected set; }
        public int ByteSize { get; protected set; }
        public int BitWidth { get; protected set; }
        public string DataType { get; protected set; }
        public string DetectionMethod { get; protected set; }

        protected SaveField(
            string name,
            object value,
            long globalOffset,
            int blockOffset,
            string block,
            int byteSize,
            int bitWidth,
            string dataType,
            string detectionMethod)
        {
            Name = name;
            Value = value;
            GlobalOffset = globalOffset;
            BlockOffset = blockOffset;
            Block = block;
            ByteSize = byteSize;
            BitWidth = bitWidth;
            DataType = dataType;
            DetectionMethod = detectionMethod;
        }

        public override string ToString()
        {
            return
                $"{Name}: {Value} | " +
                $"Global: 0x{GlobalOffset:X} | " +
                $"Block: {Block} | " +
                $"Block Offset: 0x{BlockOffset:X} | " +
                $"Bytes: {ByteSize} | " +
                $"Bits: {BitWidth} | " +
                $"Type: {DataType} | " +
                $"Detection: {DetectionMethod}";
        }
    }
}
