namespace HuffmanTool;

[Serializable]
public class HuffmanNode : IComparable<HuffmanNode>
{
    public byte Data { get; set; }
    public uint Frequency {get; set;}

    public HuffmanNode? Left { get; set; }
    public HuffmanNode? Right { get; set; }
    
    public bool IsLeaf => Left == null && Right == null;
    
    public int CompareTo(HuffmanNode? other)
    {
        if (other == null) return 1;

        var freqComparison = Frequency.CompareTo(other.Frequency);
        return freqComparison != 0 ? freqComparison : Data.CompareTo(other.Data);
    }
    
    public override string ToString()
    {
        return $"[{Data} {Frequency}] ";
    }

    public static HuffmanNode Merge(HuffmanNode left, HuffmanNode right)
    {
        return new HuffmanNode()
        {
            Left = left,
            Right = right,
            Frequency = left.Frequency + right.Frequency
        };
    }
}