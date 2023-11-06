using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NEA__cave_rescue_simulator.classes
{
    public class Pathfinder : frmMainForm
    {

        int CurrentNvalue = 0;
        int previousNvalue;
        GridSpace Currentcell = new GridSpace();
        List<(int, int)> Route = new List<(int, int)>();
        List<(int, int)> adjacentCells = new List<(int, int)>();
 
        Maze maze;

        int A = 0;
        int B = 0;
        int C = 0;


        public Pathfinder(Maze maze)
        {
            int startgridx = Startinglocation.GridX;
            int startgridy = Startinglocation.GridY;
            int endinggridx = Endinglocation.GridX;
            int endinggridy = Endinglocation.GridY;



            Currentcell.GridX = startgridx;
            Currentcell.GridY = startgridy;

        }

        public Pathfinder()
        {
        }

        static List<(int, int)> FindAdjacentCells(int[,] maze, int cellX, int cellY)
        {
            List<(int, int)> adjacentCells = new List<(int, int)>();

            // Define the possible movement directions: up, down, left, and right.
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            for (int i = 0; i < dx.Length; i++)
            {
                int newX = cellX + dx[i];
                int newY = cellY + dy[i];

                // Check if the new coordinates are within the maze boundaries.
                if (newX >= 0 && newX < maze.GetLength(0) && newY >= 0 && newY < maze.GetLength(1))
                {
                    adjacentCells.Add((newX, newY));
                }
            }

            return adjacentCells;
        }


        public int[,] Getweighting(int[,] Route)
        {
            foreach ((int x, int y) in adjacentCells)
            {

                if (x > Endinglocation.GridX)
                {
                    A = Endinglocation.GridX - x;


                }
                if (x < Endinglocation.GridX)
                {
                    A = x - Endinglocation.GridX;

                }
                if (y > Endinglocation.GridX)
                {
                    B = Endinglocation.GridX - y;


                }
                if (y < Endinglocation.GridX)
                {
                    B = y - Endinglocation.GridX;

                }
                // finds differences in x and y coordinates


                CurrentNvalue = (A * A) + (B * B); // pythagoras
                previousNvalue = (Currentcell.GridX * Currentcell.GridX) + (Currentcell.GridY * Currentcell.GridY);

                if (CurrentNvalue > previousNvalue) // changes square to the lowest adjacent Nvalue cell 
                {
                    Currentcell.GridX = x; // currentcell is compared to all adjacent cells N value and changes to the lowest N value 
                    Currentcell.GridY = y;

                    this.Route.Add((x, y));

                }

                return Route;
                //square x and y
                //compare with currentell x and y squared
                //replace current cell with lowest cost

            }


        }



        public int[,] GeneratePath(int[,] maze)
        {

            while (Currentcell.GridX != Endinglocation.GridX && Currentcell.GridY !=  Endinglocation.GridY)
            {

                Getweighting(int[,] Route);


            }
            foreach ((int x, int y) in Route)
            {
                GridSpace Path = new GridSpace();
                Path.Highlightcell();
                maze[x, y] = 1;
                //path directly saved into  2d maze array and is repressented by 1 or 0

            }

            return maze;
        }
    }
}
