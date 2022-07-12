using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace GraphTheory
{
    public static class DijkstraShortestPath
    {
        public static void FindSortestPath(int noOfNodes, int sourceVertex, List<List<int>> adjacencyMatrix)
        {
            var visitedHashMap = new Dictionary<int, bool>();
            var vertexDistanceList = new List<VertexDistance>();
            for (int i = 0; i < noOfNodes; i++)
            {
                visitedHashMap.Add(i, false);
                vertexDistanceList.Add(new VertexDistance { Vertex = i, Distance = int.MaxValue });
            }
            vertexDistanceList[sourceVertex].Distance = 0;
            var vertexDistanceQueue = new Queue<VertexDistance>();

            EnqueueVetexWeight(vertexDistanceQueue, vertexDistanceList[sourceVertex]);
            visitedHashMap[sourceVertex] = true;
            while (vertexDistanceQueue.Any())
            {
                VertexDistance currentVertex = vertexDistanceQueue.Dequeue();
                visitedHashMap[currentVertex.Vertex] = true;
                for (int i = 0; i < noOfNodes; i++)
                {
                    if (adjacencyMatrix[currentVertex.Vertex][i] < int.MaxValue && visitedHashMap[i] == false)
                    {
                        int newDistance = vertexDistanceList[currentVertex.Vertex].Distance + adjacencyMatrix[currentVertex.Vertex][i];
                        if (newDistance < vertexDistanceList[i].Distance)
                        {
                            vertexDistanceList[i].Distance = newDistance;
                            vertexDistanceQueue = EnqueueVetexWeight(vertexDistanceQueue, vertexDistanceList[i]);
                        }
                    }
                }
            }

            foreach (VertexDistance vertexDistance in vertexDistanceList)
            {
                Console.WriteLine($"Distance from {sourceVertex} => {vertexDistance.Vertex} : {vertexDistance.Distance}");
            }
        }

        public static Queue<VertexDistance> EnqueueVetexWeight(Queue<VertexDistance> vertexDistanceQueue, VertexDistance newVetex)
        {
            vertexDistanceQueue.Enqueue(newVetex);
            vertexDistanceQueue = new Queue<VertexDistance>(vertexDistanceQueue.OrderBy(x => x.Distance));

            return vertexDistanceQueue;
        }

        #region LeetCode Solution
        public static List<int> bfs(int n, int m, List<List<int>> edges, int s)
        {
            var adjacencyMatrix = new List<List<int>>();
            for (int i = 0; i <= n; i++)
            {
                var adjacencySubMatrix = new List<int>();
                for (int j = 0; j <= n; j++)
                {
                    adjacencySubMatrix.Add(int.MinValue);
                }
                adjacencyMatrix.Add(adjacencySubMatrix);
            }

            foreach (var edge in edges)
            {
                adjacencyMatrix[edge[0]][edge[1]] = 6;
                adjacencyMatrix[edge[1]][edge[0]] = 6;
            }

            var visitedHashMap = new Dictionary<int, bool>();
            var vertexDistanceList = new Dictionary<int, int>();
            for (int i = 0; i <= n; i++)
            {
                visitedHashMap.Add(i, false);
                vertexDistanceList.Add(i, int.MaxValue);
            }
            vertexDistanceList[s] = 0;
            var vertexDistanceQueue = new Queue<KeyValuePair<int, int>>();

            EnqueueVetexWeightKeyValue(vertexDistanceQueue, vertexDistanceList.ElementAt(s));
            visitedHashMap[s] = true;
            while (vertexDistanceQueue.Any())
            {
                KeyValuePair<int, int> currentVertex = vertexDistanceQueue.Dequeue();
                visitedHashMap[currentVertex.Key] = true;
                for (int i = 1; i <= n; i++)
                {
                    if (adjacencyMatrix[currentVertex.Key][i] > int.MinValue && visitedHashMap[i] == false)
                    {
                        int newDistance = vertexDistanceList[currentVertex.Key] + adjacencyMatrix[currentVertex.Key][i];
                        if (newDistance < vertexDistanceList[i])
                        {
                            vertexDistanceList[i] = newDistance;
                            EnqueueVetexWeightKeyValue(vertexDistanceQueue, vertexDistanceList.ElementAt(i));
                        }
                    }
                }
            }
            var resultList = new List<int>();
            foreach (KeyValuePair<int, int> vertexDistance in vertexDistanceList)
            {
                if (vertexDistance.Key == 0 || vertexDistance.Key == s)
                    continue;

                if (vertexDistance.Value == int.MaxValue)
                    resultList.Add(-1);
                else
                    resultList.Add(vertexDistance.Value);
            }

            return resultList;
        }

        public static void EnqueueVetexWeightKeyValue(Queue<KeyValuePair<int, int>> vertexDistanceQueue, KeyValuePair<int, int> newVetex)
        {
            vertexDistanceQueue.Enqueue(newVetex);
            vertexDistanceQueue = new Queue<KeyValuePair<int, int>>(vertexDistanceQueue.OrderBy(x => x.Value).ToDictionary(x => x.Key, y => y.Value));
        }
        #endregion
    }
}
