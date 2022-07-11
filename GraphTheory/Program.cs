using System;
using System.Collections.Generic;

namespace GraphTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfNodes = 9;
            List<List<bool>> graphAdjacencyMatrix = BuildGraph.Build(noOfNodes, null);
            TraverseGraph.BreadthFirstSearch(noOfNodes, graphAdjacencyMatrix);
        }
    }
}
