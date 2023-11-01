using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA__cave_rescue_simulator.classes
{
    public class Pathfinder 
    {
        public int[,] Graph = new int[30,20];

        private void DijkstraAlgorithm(int[,] graph, int src)
        {
            int[] dist = new int[V];
            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinDistance(dist, sptSet);
                sptSet[u] = true;

                for (int v = 0; v < V; v++)
                {
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                    }
                }
            }

            PrintSolution(dist);


        }
        class MazeGraph
        {
            private int rows;
            private int cols;
            private List<int>[] adjacencyList;

            public MazeGraph(char[,] maze)
            {
                rows = maze.GetLength(0);
                cols = maze.GetLength(1);
                int totalNodes = rows * cols;

                adjacencyList = new List<int>[totalNodes];
                for (int i = 0; i < totalNodes; i++)
                {
                    adjacencyList[i] = new List<int>();
                }

                // Define possible movements (up, down, left, right)
                int[] dx = { -1, 1, 0, 0 };
                int[] dy = { 0, 0, -1, 1 };

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        if (maze[i, j] != '#') // Check if it's a traversable cell
                        {
                            int node = i * cols + j;

                            for (int k = 0; k < 4; k++)
                            {
                                int x = i + dx[k];
                                int y = j + dy[k];

                                if (x >= 0 && x < rows && y >= 0 && y < cols && maze[x, y] != '#')
                                {
                                    int neighbor = x * cols + y;
                                    adjacencyList[node].Add(neighbor);
                                }
                            }
                        }
                    }
                }
            }

            public List<int> GetNeighbors(int node)
            {
                if (node < 0 || node >= adjacencyList.Length)
                    return new List<int>();

                return adjacencyList[node];
            }

            public int GetTotalNodes()
            {
                return adjacencyList.Length;
            }
        }

        class Program
        {
            static void Main()
            {
                char[,] maze = {
            {'#', '#', '#', '#', '#'},
            {'#', 'S', ' ', ' ', '#'},
            {'#', '#', '#', 'E', '#'},
            {'#', ' ', ' ', ' ', '#'},
            {'#', '#', '#', '#', '#'}
        };

                MazeGraph graph = new MazeGraph(maze);

                int startNode = 1; // S
                int endNode = 13; // E

                Console.WriteLine("Neighbors of node " + startNode + ": " + string.Join(", ", graph.GetNeighbors(startNode)));
                Console.WriteLine("Total nodes in the graph: " + graph.GetTotalNodes());
            }

        }
}
