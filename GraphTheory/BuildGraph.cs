using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public static class BuildGraph
    {
        public static List<List<int>> Build(int noOfNodes, List<Edge> edgeList, int infiniteValue = int.MinValue, bool isDirected = false)
        {
            var adjacencyMatrix = new List<List<int>>();
            for (int i = 0; i < noOfNodes; i++)
            {
                var adjacencySubMatrix = new List<int>();
                for (int j = 0; j < noOfNodes; j++)
                {
                    adjacencySubMatrix.Add(infiniteValue);
                }
                adjacencyMatrix.Add(adjacencySubMatrix);
            }

            if (edgeList == null)
            {
                edgeList = GetDefaultEdgeList();
            }

            foreach (Edge edge in edgeList)
            {
                adjacencyMatrix[edge.SourceVertex][edge.DestinationVertex] = edge.Weight;
                if (isDirected == false)
                {
                    adjacencyMatrix[edge.DestinationVertex][edge.SourceVertex] = edge.Weight;
                }
            }

            return adjacencyMatrix;
        }

        public static List<Edge> GetDefaultEdgeList()
        {
            var edgeList = new List<Edge> {
                new Edge(0, 1, 7),
                new Edge(0, 2, 4),
                new Edge(0, 3, 1),
                new Edge(1, 2, 2),
                new Edge(2, 3, 1)
            };

            return edgeList;
        }
    }
}