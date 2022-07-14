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
            /*
             5 7
1 2 20
1 3 50
1 4 70
1 5 90
2 3 30
3 4 40
4 5 60
             */
            var result = KruskalMst.kruskals(5, new List<int> { 1, 1, 1, 1, 2, 3, 4 }, new List<int> { 2, 3, 4, 5, 3, 4, 5 }, new List<int> { 20, 50, 70, 90, 30, 40, 60 });
        }
    }
}
