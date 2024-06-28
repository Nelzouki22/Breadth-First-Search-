using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Example graph represented as an adjacency list
        var graph = new Dictionary<int, List<int>>
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 3, 4 } },
            { 2, new List<int> { 0, 5 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1, 5 } },
            { 5, new List<int> { 2, 4 } }
        };

        Console.WriteLine("BFS starting from node 0:");
        BFS(graph, 0);
    }

    static void BFS(Dictionary<int, List<int>> graph, int start)
    {
        // Initialize the queue with the start node
        var queue = new Queue<int>();
        queue.Enqueue(start);

        // Initialize the set of visited nodes
        var visited = new HashSet<int> { start };

        while (queue.Count > 0)
        {
            // Dequeue a node from the front of the queue
            int currentNode = queue.Dequeue();
            Console.Write(currentNode + " ");

            // Iterate over all adjacent nodes
            foreach (int neighbor in graph[currentNode])
            {
                if (!visited.Contains(neighbor))
                {
                    // Enqueue non-visited adjacent nodes
                    queue.Enqueue(neighbor);
                    // Mark the node as visited
                    visited.Add(neighbor);
                }
            }
        }
    }
}
