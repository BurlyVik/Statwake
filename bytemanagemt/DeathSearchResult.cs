namespace edcs_edlen_death_counter_service
{

    public class DeathSearchResult
    {
        public int Value { get; }
        public int GlobalOffset { get; }
        public int BlockOffset { get; }
        public DeathSearchResult(
            int value,
            int globalOffset,
            int blockOffset)
        {
            Value = value;
            GlobalOffset = globalOffset;
            BlockOffset = blockOffset;
        }
    }
}
