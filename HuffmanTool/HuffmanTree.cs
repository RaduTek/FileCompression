namespace HuffmanTool;

[Serializable]
public class HuffmanTree(HuffmanNode root)
{
    private HuffmanNode? _root = root;
}

public static class HuffmanTreeBuilder
{
    public static HuffmanTree FromPriorityQueue(PriorityQueue<HuffmanNode, uint> nodeQueue)
    {
        while (nodeQueue.Count > 1)
        {
            var node = HuffmanNode.Merge(nodeQueue.Dequeue(), nodeQueue.Dequeue());
            nodeQueue.Enqueue(node, node.Frequency); 
        }

        return new HuffmanTree(nodeQueue.Dequeue());
    }
    
    public static HuffmanTree FromStream(Stream input)
    {
        var frequencies = new uint[256];
        var nodeQueue = new PriorityQueue<HuffmanNode, uint>();

        int data;
        while ((data = input.ReadByte()) != -1)
        {
            frequencies[data]++;
        }

        for (var i = 0; i < 256; i++)
        {
            if (frequencies[i] > 0)
            {
                Console.WriteLine(frequencies[i]);
                nodeQueue.Enqueue(new HuffmanNode
                {
                    Data = (byte)i, Frequency = frequencies[i]
                }, frequencies[i]);
            }
        }
        
        return FromPriorityQueue(nodeQueue);
    }
}