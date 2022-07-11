using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public static class BuildGraph
    {
        public static List<List<bool>> Build(int noOfNodes, List<Edge> edgeList, bool isDirected = false)
        {
            var adjacencyMatrix = new List<List<bool>>();
            for (int i = 0; i < noOfNodes; i++)
            {
                var adjacencySubMatrix = new List<bool>();
                for (int j = 0; j < noOfNodes; j++)
                {
                    adjacencySubMatrix.Add(false);
                }
                adjacencyMatrix.Add(adjacencySubMatrix);
            }

            if (edgeList == null)
            {
                edgeList = GetDefaultEdgeList();
            }

            foreach (Edge edge in edgeList)
            {
                adjacencyMatrix[edge.SourceVertex][edge.DestinationVertex] = true;
                if (isDirected == false)
                {
                    adjacencyMatrix[edge.DestinationVertex][edge.SourceVertex] = true;
                }
            }

            return adjacencyMatrix;
        }

        public static List<Edge> GetDefaultEdgeList()
        {
            var edgeList = new List<Edge> {
                new Edge(0, 1),
                new Edge(0, 3),
                new Edge(2, 1),
                new Edge(2, 3),
                new Edge(3, 4),
                new Edge(4, 2),
                new Edge(4, 5),
                new Edge(5, 2),
                new Edge(6, 7),
                new Edge(7, 8)
            };

            return edgeList;
        }
    }
}