using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public struct GraphEdge
    {
        public int Source;
        public int Destination;
        public int Weight;
    }

    public struct Subset
    {
        public int Parent;
        public int Rank;
    }

    public static class KruskalMst
    {
        private static int Find(Subset[] subsets, int i)
        {
            if (subsets[i].Parent != i)
                subsets[i].Parent = Find(subsets, subsets[i].Parent);

            return subsets[i].Parent;
        }

        private static void Union(Subset[] subsets, int x, int y)
        {
            int xroot = Find(subsets, x);
            int yroot = Find(subsets, y);

            if (subsets[xroot].Rank < subsets[yroot].Rank)
                subsets[xroot].Parent = yroot;
            else if (subsets[xroot].Rank > subsets[yroot].Rank)
                subsets[yroot].Parent = xroot;
            else
            {
                subsets[yroot].Parent = xroot;
                ++subsets[xroot].Rank;
            }
        }


        public static int kruskals(int gNodes, List<int> gFrom, List<int> gTo, List<int> gWeight)
        {
            var inputEdgeList = new List<GraphEdge>();
            int i = 0;
            int e = 0;
            for (int k = 0; k < gFrom.Count; k++)
            {
                inputEdgeList.Add(new GraphEdge { Source = gFrom[k], Destination = gTo[k], Weight = gWeight[k] });
            }
            var inputEdgeArray = inputEdgeList.ToArray();
            Array.Sort(inputEdgeArray, delegate (GraphEdge a, GraphEdge b)
            {
                return a.Weight.CompareTo(b.Weight);
            });
            inputEdgeList = inputEdgeArray.ToList();

            Subset[] subsets = new Subset[gNodes + 1];

            for (int v = 0; v <= gNodes; ++v)
            {
                subsets[v].Parent = v;
                subsets[v].Rank = 0;
            }
            int totalWeight = 0;
            while (e < gFrom.Count())
            {
                GraphEdge nextEdge = inputEdgeList[i++];
                int x = Find(subsets, nextEdge.Source);
                int y = Find(subsets, nextEdge.Destination);

                if (x != y)
                {
                    totalWeight += nextEdge.Weight;
                    Union(subsets, x, y);                    
                }

                e++;
            }

            return totalWeight;
        }
    }
}
