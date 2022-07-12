using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
