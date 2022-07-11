using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public static class TraverseGraph
    {
        public static void DepthFirstSearch(int noOfNodes, List<List<int>> adjacencyMatrix)
        {
            Console.WriteLine("=====DFS=====");
            Dictionary<int, bool> visitedHashMap = new Dictionary<int, bool>();
            for (int i = 0; i < noOfNodes; i++)
            {
                visitedHashMap.Add(i, false);
            }
            int totalConnectedGraphCount = 0;
            for (int i = 0; i < noOfNodes; i++)
            {
                if (visitedHashMap[i] == false)
                {
                    totalConnectedGraphCount++;
                    DepthFirstPrint(i, adjacencyMatrix, visitedHashMap);
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Total connected graphs: {totalConnectedGraphCount}");
        }

        public static void DepthFirstPrint(int node, List<List<int>> adjacencyMatrix, Dictionary<int, bool> visitedHashMap)
        {
            Console.WriteLine(node);
            visitedHashMap[node] = true;
            int noOfNodes = visitedHashMap.Count;
            for (int i = 0; i < noOfNodes; i++)
            {
                if (adjacencyMatrix[node][i] > int.MinValue && visitedHashMap[i] == false)
                {
                    DepthFirstPrint(i, adjacencyMatrix, visitedHashMap);
                }
            }
        }

        public static void BreadthFirstSearch(int noOfNodes, List<List<int>> adjacencyMatrix)
        {
            Console.WriteLine("=====BFS=====");
            Dictionary<int, bool> visitedHashMap = new Dictionary<int, bool>();
            for (int i = 0; i < noOfNodes; i++)
            {
                visitedHashMap.Add(i, false);
            }
            int totalConnectedGraphCount = 0;
            for (int i = 0; i < noOfNodes; i++)
            {
                if (visitedHashMap[i] == false)
                {
                    totalConnectedGraphCount++;
                    BreadthFirstPrint(i, adjacencyMatrix, visitedHashMap);
                    Console.WriteLine();
                }
            }

            Console.WriteLine($"Total connected graphs: {totalConnectedGraphCount}");
        }

        public static void BreadthFirstPrint(int node, List<List<int>> adjacencyMatrix, Dictionary<int, bool> visitedHashMap)
        {
            int noOfNodes = visitedHashMap.Count;
            var nodeQueue = new Queue<int>();
            nodeQueue.Enqueue(node);
            visitedHashMap[node] = true;
            while (nodeQueue.Any())
            {
                int currentNode = nodeQueue.Dequeue();
                Console.WriteLine(currentNode);
                for (int i = 0; i < noOfNodes; i++)
                {
                    if (adjacencyMatrix[currentNode][i] > int.MinValue && visitedHashMap[i] == false)
                    {
                        nodeQueue.Enqueue(i);
                        visitedHashMap[i] = true;
                    }
                }
            }
        }
    }
}
