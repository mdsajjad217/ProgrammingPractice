using System;
using System.Collections.Generic;

namespace GraphTheory
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfNodes = 4;
            List<List<int>> graphAdjacencyMatrix = BuildGraph.Build(noOfNodes, null);
            TraverseGraph.DepthFirstSearch(noOfNodes, graphAdjacencyMatrix);
            TraverseGraph.BreadthFirstSearch(noOfNodes, graphAdjacencyMatrix);
            graphAdjacencyMatrix = BuildGraph.Build(noOfNodes, null, int.MaxValue);
            DijkstraShortestPath.FindSortestPath(noOfNodes, 0, graphAdjacencyMatrix);
            var res = DijkstraShortestPath.bfs(4, 2, new List<List<int>> { new List<int> { 1, 2 }, new List<int> { 1, 3 } }, 1);
        }
    }
}
