using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        List<int> adjacentcellcoordinates = new List<int>();
        Random RNG = new Random();
        StreamWriter SR = new StreamWriter("Grid.txt");
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

            adjacent_cells.Add(maze.maze[start_x, start_y + 1]); // Up
            adjacent_cells.Add(maze.maze[start_x, start_y - 1]); // Down
            adjacent_cells.Add(maze.maze[start_x - 1 , start_y]); //left 
            adjacent_cells.Add(maze.maze[start_x +1, start_y]);//right
            adjacent_cells.Add(maze.maze[start_x + 1, start_y + 1]); //top right 
            adjacent_cells.Add(maze.maze[start_x - 1, start_y + 1]);//top left 
            adjacent_cells.Add(maze.maze[start_x + 1, start_y -1 ]);//bottom right
            adjacent_cells.Add(maze.maze[start_x - 1, start_y - 1 ]);//bottom left 

            // adds all adjacent cells around current cell 

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
                adjacentcellcoordinates.Add(cell.GridX);
                adjacentcellcoordinates.Add(cell.GridY);
               
                //adds coodinates from the adjacent cells in the list 

            }

            return false;

        }
       public string Generatewalls()
        {

            // have to save the white and black squares in a text file using the coordinates 
            ////uuse co ordinates to add walls from co ordinates list
            for (int i = 0; i <= adjacentcellcoordinates.Count; i++)
            {
                for (int j = 1; j <= adjacentcellcoordinates.Count; j++)
                {

                    Wall.GridX = adjacentcellcoordinates[i];  // coordinates of wall from list
                    Wall.GridY = adjacentcellcoordinates[j];

                    Wall.isWallpresent = true;

                    return "B";

                }

                return "W";
            }
            return "W";
        }
        public void Generategap()
        {
            
            currentcell.GridX = currentcellcoordinates.Peek();
            currentcellcoordinates.Pop();
            currentcell.GridY = currentcellcoordinates.Peek();
            currentcellcoordinates.Pop();
            
        }
        public void Dispaywalls()
        {
            for (int i = 0; i <= 7; i++)
            {
                SR.Write(Generatewalls());
                for () 
                {
                    SR.WriteLine(); // puts a the string under a line 

                }
                
               
            }          
    
        }

    }
}
