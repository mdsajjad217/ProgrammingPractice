using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTheory
{
    public static class TraverseGraph
    {
        public static void DepthFirstSearch(int noOfNodes, List<List<bool>> adjacencyMatrix)
        {
            Console.WriteLine("=====DFS=====");
            Dictionary<int, bool> visitedHashMap = new Dictionary<int, bool>();
            for (int i = 0; i < noOfNodes; i++)
            {
                visitedHashMap.Add(i, false);
            }

            for (int i = 0; i < noOfNodes; i++)
            {
                if (visitedHashMap[i] == false)
                {
                    DepthFirstPrint(i, adjacencyMatrix, visitedHashMap);
                    Console.WriteLine();
                }
            }
        }

        public static void DepthFirstPrint(int node, List<List<bool>> adjacencyMatrix, Dictionary<int, bool> visitedHashMap)
        {
            Console.WriteLine(node);
            visitedHashMap[node] = true;
            int noOfNodes = visitedHashMap.Count;
            for (int i = 0; i < noOfNodes; i++)
            {
                if (adjacencyMatrix[node][i] == true && visitedHashMap[i] == false)
                {
                    DepthFirstPrint(i, adjacencyMatrix, visitedHashMap);
                }
            }
        }

        public static void BreadthFirstSearch(int noOfNodes, List<List<bool>> adjacencyMatrix)
        {
            Console.WriteLine("=====BFS=====");
            Dictionary<int, bool> visitedHashMap = new Dictionary<int, bool>();
            for (int i = 0; i < noOfNodes; i++)
            {
                visitedHashMap.Add(i, false);
            }

            for (int i = 0; i < noOfNodes; i++)
            {
                if (visitedHashMap[i] == false)
                {
                    BreadthFirstPrint(i, adjacencyMatrix, visitedHashMap);
                    Console.WriteLine();
                }
            }
        }

        public static void BreadthFirstPrint(int node, List<List<bool>> adjacencyMatrix, Dictionary<int, bool> visitedHashMap)
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
                    if (adjacencyMatrix[currentNode][i] == true && visitedHashMap[i] == false)
                    {
                        nodeQueue.Enqueue(i);
                        visitedHashMap[i] = true;
                    }
                }
            }
        }
    }
}
