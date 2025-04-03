namespace HuffmanTool;

public static class Program
{
    public static void Main(string[] args)
    {
        if (args is not ["-c" or "-d", _, _])
        {
            Console.WriteLine($"Usage: HuffmanTool -c <input> -d <output>");
        }

        if (args[0] == "-c")
        {   
            // Compression mode
            var inputFile = File.OpenRead(args[1]);
            
            var tree = HuffmanTreeBuilder.FromStream(inputFile);
            
            
        }
        else
        {
            // Decompression mode
        }
    }
}