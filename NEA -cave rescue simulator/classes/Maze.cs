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
        private Gridspace[,] maze;

        public void GenerateMaze(int width , int height)
        {
            maze = new Gridspace[width, height];
            var stream = File.OpenText("Grid.txt");
            var line = "";
            var y = 0;


            while ((line = stream.ReadLine()) != null)  
            {
                var line_grid_space = line.Split(',');
                for (var x = 0; x < line_grid_space.Length; x++) //  i = x , y = y 
                { 
                    var g_space = new Gridspace()
                    {                                              //allows to ask for vector datas its already loaded
                        IsWalkable = line_grid_space[x] == "W"     // therefore wont need to instantiate 
                    };

                    maze[x, y] = g_space;
                }

                y++;       // literally create maze (program classes just its function)
            }



            stream.Close();

        }


    }



}
