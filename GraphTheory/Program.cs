using System;
using System.Collections.Generic;

namespace GraphTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfNodes = 9;
            List<List<int>> graphAdjacencyMatrix = BuildGraph.Build(noOfNodes, null);
            TraverseGraph.DepthFirstSearch(noOfNodes, graphAdjacencyMatrix);
            TraverseGraph.BreadthFirstSearch(noOfNodes, graphAdjacencyMatrix);
        }
    }
}
