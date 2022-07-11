using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public class Edge
    {
        public int SourceVertex;
        public int DestinationVertex;
        public int Weight;

        public Edge(int sourceVertex, int destinationVertex, int weight = 1)
        {
            SourceVertex = sourceVertex;
            DestinationVertex = destinationVertex;
            Weight = weight;
        }
    }
}
