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
        int[,] maze = new int[30, 20];
         int width = 30;
        int height = 20;

        public Maze()
        {
            

        }

        public void Displaymaze()
        {
            StreamReader sr = new StreamReader("Grid.txt");


            for (int i  = 0;i < width;i++) //y 
            {

                for (int j = 0; j < height; j++) // x
                {
                    maze[i, j] = 0; //no walls 

                    if (maze[i,j] == 1) // = wall
                    {
                      


                    }
                }
            }

        }
        public void GenerateMaze()
        {
            StreamWriter sw = new StreamWriter("Grid.txt");

            for (int i = 0; i < width; i++) //y 
            {

                for (int j = 0; j < height; j++) // x
                {
                   if ( maze[i, j] == 0)
                    {
                        sw.Write(0);
                    } //no walls 
                 
                   if (maze[i, j] == 1) // = wall
                    {


                        sw.Write(1);
                    }
                }
            }



        }

    }

}
