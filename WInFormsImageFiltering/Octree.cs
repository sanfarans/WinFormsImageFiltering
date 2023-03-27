using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WInFormsImageFiltering
{
    internal class Octree
    {
        internal class Node
        {
            public bool IsLeaf;
            public long SumR;
            public long SumG;
            public long SumB;
            public long Count;
            public Node[] Children = new Node[8];


        }

        public Node? Root;
        public int LeafCount;
        public int MaxLeaves;
        public List<Node>[] InnerNodes;

        public Octree(Bitmap image, int maxLeaves)
        {
            Root = null;
            LeafCount = 0;
            MaxLeaves = maxLeaves;
            InnerNodes = new List<Node>[8];
            for (int i = 0; i < 8; ++i)
                InnerNodes[i] = new List<Node>();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Add(image.GetPixel(x, y));
                    while (LeafCount > MaxLeaves)
                    {
                        Reduce();
                    }
                }
            }
        }

        public Color Find(Color color)
        {
            Node node = Root;
            int depth = 0;
            while (! node.IsLeaf)
            {
                int i = ChildIndex(color, depth);
                node = node.Children[i];
                depth++;
            }
            return Color.FromArgb(
                color.A,
                (int)(node.SumR / node.Count),
                (int)(node.SumG / node.Count),
                (int)(node.SumB / node.Count)
            );
        }

        private void Add(Color color)
        {
            if (Root == null)
            {
                Root = CreateNode(0);
            }
            AddRecursive(Root, color, 0);
        }

        private void Reduce()
        {
            int depth = 7;
            for (int i = 7; i >= 0; --i)
            {
                depth = i;
                if (InnerNodes[i].Count > 0)
                {
                    break;
                }
            }
            Node node = InnerNodes[depth].Last();
            
            int removed = 0;
            for (int k = 0; k < 8; ++k)
            {
                if (node.Children[k] != null)
                {
                    node.SumR += node.Children[k].SumR;
                    node.SumG += node.Children[k].SumG;
                    node.SumB += node.Children[k].SumB;
                    node.Count += node.Children[k].Count;
                    node.Children[k] = null;
                    removed++;
                }
            }
            InnerNodes[depth].Remove(node);
            node.IsLeaf = true;
            LeafCount += 1 - removed;
        }

        private void AddRecursive(Node parent, Color color, int depth)
        {
            if (parent.IsLeaf)
            {
                parent.SumR += color.R;
                parent.SumG += color.G;
                parent.SumB += color.B;
                parent.Count += 1;
            } else
            {
                int i = ChildIndex(color, depth);
                if (parent.Children[i] == null)
                {
                    parent.Children[i] = CreateNode(depth + 1);
                }
                AddRecursive(parent.Children[i], color, depth + 1);
            }
        }

        private static int ChildIndex(Color color, int depth)
        {
            int bitR = (color.R >> (7 - depth)) & 0x1;
            int bitG = (color.G >> (7 - depth)) & 0x1;
            int bitB = (color.B >> (7 - depth)) & 0x1;

            return (bitR << 2) | (bitG << 1) | bitB;
        }

        private Node CreateNode(int depth)
        {
            Node node = new Node();
            node.Count = 0;
            node.IsLeaf = (depth == 8);
            if (!node.IsLeaf)
            {
                InnerNodes[depth].Add(node);
            } else
            {
                LeafCount++;
            }
            return node;
        }

    }
}
