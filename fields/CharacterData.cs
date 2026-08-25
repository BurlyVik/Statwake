using Newtonsoft.Json;
using System.Reflection;

namespace statwake
{

    public class CharacterName
    {
        public string Text { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public long GlobalOffset { get; set; }
        public int BlockOffset { get; set; }
        public string Block { get; set; }
        public int ByteSize { get; set; }
        public int BitWidth { get; set; }
        public string DataType { get; set; }
        public string DetectionMethod { get; set; }
    }

    public class CharacterLevel
    {
        public int ValueInt { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public long GlobalOffset { get; set; }
        public int BlockOffset { get; set; }
        public string Block { get; set; }
        public int ByteSize { get; set; }
        public int BitWidth { get; set; }
        public string DataType { get; set; }
        public string DetectionMethod { get; set; }
    }

    public class CharacterPlaytime
    {
        public long Seconds { get; set; }
        public string Name { get; set; }
        public long Value { get; set; }
        public long GlobalOffset { get; set; }
        public int BlockOffset { get; set; }
        public string Block { get; set; }
        public int ByteSize { get; set; }
        public int BitWidth { get; set; }
        public string DataType { get; set; }
        public string DetectionMethod { get; set; }
    }

    public class CharacterDeathCount
    {
        public int Count { get; set; }
        public bool Found { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public long GlobalOffset { get; set; }
        public int BlockOffset { get; set; }
        public string Block { get; set; }
        public int ByteSize { get; set; }
        public int BitWidth { get; set; }
        public string DataType { get; set; }
        public string DetectionMethod { get; set; }
    }

    public class CharacterProfile
    {
        public int SlotIndex { get; set; }
        public bool IsActive { get; set; }
        public CharacterName Name { get; set; }
        public CharacterLevel Level { get; set; }
        public CharacterPlaytime Playtime { get; set; }
        public CharacterDeathCount DeathCount { get; set; }
        public long ProfileLength { get; set; }
    }
}