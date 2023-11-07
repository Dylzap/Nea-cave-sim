using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NEA__cave_rescue_simulator.classes
{
    public class Pathfinder 
    {

        public static List<Node> FindPath(int[,] maze, Node start, Node end)
        {
            List<Node> openList = new List<Node>();
            bool[,] closedList = new bool[maze.GetLength(0), maze.GetLength(1)];
            openList.Add(start);

            while (openList.Count > 0)
            {
                Node current = openList[0];
                int currentIndex = 0;

                for (int i = 1; i < openList.Count; i++)
                {
                    if (openList[i].F < current.F || (openList[i].F == current.F && openList[i].H < current.H))
                    {
                        current = openList[i];
                        currentIndex = i;
                    }
                }

                openList.RemoveAt(currentIndex);
                closedList[current.X, current.Y] = true;

                if (current.X == end.X && current.Y == end.Y)
                {
                    return ReconstructPath(current);
                }

                List<Node> neighbors = GetNeighbors(maze, current, end);

                foreach (Node neighbor in neighbors)
                {
                    if (closedList[neighbor.X, neighbor.Y])
                    {
                        continue;
                    }

                    int tentativeG = current.G + 1;

                    if (!openList.Contains(neighbor) || tentativeG < neighbor.G)
                    {
                        neighbor.Parent = current;
                        neighbor.G = tentativeG;
                        neighbor.H = CalculateH(neighbor, end);

                        if (!openList.Contains(neighbor))
                        {
                            openList.Add(neighbor);
                        }
                    }
                }
            }

            return null;
        }

        private static List<Node> GetNeighbors(int[,] maze, Node node, Node end)
        {
            List<Node> neighbors = new List<Node>();
            int maxX = maze.GetLength(0) - 1;
            int maxY = maze.GetLength(1) - 1;

            int[] dx = { 0, 0, -1, 1 };
            int[] dy = { -1, 1, 0, 0 };

            for (int i = 0; i < 4; i++)
            {
                int newX = node.X + dx[i];
                int newY = node.Y + dy[i];

                if (newX >= 0 && newX <= maxX && newY >= 0 && newY <= maxY && maze[newX, newY] == 0)
                {
                    neighbors.Add(new Node(newX, newY));
                }
            }

            return neighbors;
        }

        private static int CalculateH(Node node, Node end)
        {
            return Math.Abs(node.X - end.X) + Math.Abs(node.Y - end.Y);
        }

        private static List<Node> ReconstructPath(Node node)
        {
            List<Node> path = new List<Node>();
            while (node != null)
            {
                path.Add(node);
                node = node.Parent;
            }
            path.Reverse();
            return path;
        }
    }
}
