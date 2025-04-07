namespace HuffmanTool;

public class HuffmanFile
{
    public HuffmanTree Tree { get; private set; }
}

public static class HuffmanFileCodec
{
    public static void Encode(HuffmanFile file, Stream output)
    {
        // using var writer = new BinaryWriter(output);
        // file.Tree.Write(writer);
        // file.Stream.Write(writer);
    }

    public static HuffmanFile Decode(Stream input)
    {
        // using var reader = new BinaryReader(input);
        // var tree = HuffmanTree.Read(reader);
        // var stream = BitStream.Read(reader);
        //
        // return new HuffmanFile
        // {
        //     Tree = tree,
        //     Stream = stream
        // };
        
        return new HuffmanFile();
    }
}