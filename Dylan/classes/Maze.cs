using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NEA__cave_rescue_simulator
{
    public class Maze 
    {
        public GridSpace[,] maze;
        public int gridx;
        public int gridy;

        public Maze()
        {
        }

        public void DisplayMaze(int gridx , int gridy)
        {
            this.gridx = gridx;
            this.gridy = gridy;

            maze = new GridSpace[gridx, gridy];
            var stream = File.OpenText("Grid.txt");  // stream = streamreader 
            var line = "";
            var y = 0;

            while ((line = stream.ReadLine()) != null)   // keeps reading till there is nothing left 
            {
                var line_grid_space = line.Split(','); // spilts ?
                for (var x = 0; x < line_grid_space.Length; x++) // 
                { 
                    var g_space = new GridSpace()
                    {                                              //allows to ask for vector datas its already loaded
                        isWallpresent = line_grid_space[x] == "B"    // if row contains w then wall is present 
                    };

                    maze[x, y] = g_space;
                }

                y++;       // literally create maze (program classes just its function)
            }


            stream.Close();
        }


    }



}
