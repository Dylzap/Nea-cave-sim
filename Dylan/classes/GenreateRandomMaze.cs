using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA__cave_rescue_simulator
{
    public class GenreateRandomMaze 
    {
        List<int> adjacentcells = new List<int>();
        GridSpace currentcell = new GridSpace();
        Maze maze;
        Stack<int> currentcellcoordinates = new Stack<int>();

        List<GridSpace> visited_list = new List<GridSpace>();

        public GenreateRandomMaze(Maze maze)
        {
            this.maze = maze;


        }
        /// <summary>
        /// start_x = the x point in the maze at which to get the cells around
        /// start-y = the y point in the maze to get the cells around
        /// </summary>
        /// <param name="start_x"></param>
        /// <param name="start_y"></param>
        public void Adjacentcells(int start_x, int start_y)
        {
            currentcellcoordinates.Push(currentcell.GridX);
            currentcellcoordinates.Push(currentcell.GridY);

            currentcell.GridY = 1;

            var adjacent_cells = new List<GridSpace>();

            adjacent_cells.Add(maze.maze[start_x, start_y + 1]); // Up
            adjacent_cells.Add(maze.maze[start_x, start_y - 1]); // Down
            adjacent_cells.Add(maze.maze[start_x - 1 , start_y]); //left 
            adjacent_cells.Add(maze.maze[start_x +1, start_y]);//right

            foreach (var cell in adjacent_cells)
            {
                if (visited_list.Contains(cell))
                {
                    continue;
                }

                visited_list.Add(cell);
            }
        }
        public bool Celloutofbounds(int start_x, int start_y)
        {
            try
            {
                Adjacentcells(start_x,start_y);
            }
            catch (Exception ex)
            {
                
                return false;
            }

            return true;
        }
        public void Connectwalls()
        {


        }
        

    }
}
