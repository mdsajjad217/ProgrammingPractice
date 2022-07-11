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

        public Edge(int sourceVertex, int destinationVertex)
        {
            SourceVertex = sourceVertex;
            DestinationVertex = destinationVertex;
        }
    }
}
