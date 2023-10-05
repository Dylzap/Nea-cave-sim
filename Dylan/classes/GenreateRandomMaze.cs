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
       
        public GenreateRandomMaze(Maze maze)
        {
            this.maze = maze;
        }
        
        public void Adjacentcells()
        {
            if (currentcell.GridY == 1 && currentcell.GridX == 1)
            {
                adjacentcells.Add(currentcell.GridX);
                adjacentcells.Add(currentcell.GridY);
            }
            if (currentcell.GridY == 1 && currentcell.GridX == -1)
            {
                adjacentcells.Add(currentcell.GridX);
                adjacentcells.Add(currentcell.GridY);
            }
            if (currentcell.GridY == 1 && currentcell.GridX == 0)
            {
                adjacentcells.Add(currentcell.GridX);
                adjacentcells.Add(currentcell.GridY);
            }
            if (currentcell.GridY == 0 && currentcell.GridX == 1)
            {
                adjacentcells.Add(currentcell.GridX);
                adjacentcells.Add(currentcell.GridY);
            }
            if (currentcell.GridY == -1 && currentcell.GridX == 0)
            {
                adjacentcells.Add(currentcell.GridX);
                adjacentcells.Add(currentcell.GridY);
            }
        }

    }
}
