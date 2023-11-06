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
        List<GridSpace>adjacent_cells = new List<GridSpace>();
        List<GridSpace> visited_list = new List<GridSpace>();
        List<GridSpace> Wall_List = new List<GridSpace>();
        GridSpace Wall = new GridSpace();

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
            catch (Exception)
            {
                
                return false;
            }

            return true;
        }
        public bool Connectwalls()
        {
            foreach (GridSpace cell in adjacent_cells)
            {

                cell.isWallpresent = true;

                Wall_List.Add(cell);



            }

            return false;

        }
       public void Generatewalls()
        {


        }
        

    }
}
