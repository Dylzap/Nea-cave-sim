using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA__cave_rescue_simulator
{
    public partial class Form1 : Form
    {
        private string[,] matrix = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_startbutton_Click(object sender, EventArgs e)
        {
           SetupGridSpaces();

            Maze maze = new Maze();
            maze.GenerateMaze();
        }
        private void SetupGridSpaces()
        {
            matrix = LoadGridMap("Grid.txt"); 
            pnlGridPanel.Controls.Clear(); // Clear the existing panel

      
            int MazeSquaresHorizontal = pnlGridPanel.Width / Gridspace.GRID_SPACE_WIDTH;
            int MazeSquaresVertical = pnlGridPanel.Height / Gridspace.GRID_SPACE_HEIGHT;

            
            for (int i = 0; i < MazeSquaresVertical - 1; i++)
            {
                for (int j = 0; j < MazeSquaresHorizontal - 1; j++)
                {
                   Gridspace newGridSpace = new Gridspace();
                    newGridSpace.BackColor = Color.White;

                    if (matrix[j, i] == "X")
                    {
                        newGridSpace.BackColor = Color.Black;
                    }
                    else if (matrix[j, i] == "G") 
                    {
                        newGridSpace.BackColor = Color.Gold;
                    }

                   
                    newGridSpace.GridX = j;
                    newGridSpace.GridY = i;

                  
                    newGridSpace.Location = new Point(j * newGridSpace.Width, i * newGridSpace.Height);
                
                    this.TopLevel = false; 
                    pnlGridPanel.Controls.Add(newGridSpace); 
                }
            }
        }

        private string[,] LoadGridMap(string mapLocation)
        {
            string[,] matrixLoaded = new string[pnlGridPanel.Width / Gridspace.GRID_SPACE_WIDTH, pnlGridPanel.Height / Gridspace.GRID_SPACE_HEIGHT];

            StreamReader reader = new StreamReader(mapLocation);

            int lineNumber = 0;

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                for (int i = 0; i < parts.Length - 1; i++)
                {
                    matrixLoaded[i, lineNumber] = parts[i];
                }

                lineNumber++;
            }

            reader.Close();

            return matrixLoaded;
        }

        //GenerateMaze(EventHandler btn_startbutton)
        //{

         //   return null; 
        //}


        private void GridLocation_Click(object sender, EventArgs e)
        {
                Panel clickedPanel = (Panel)sender;
                clickedPanel.BorderStyle = BorderStyle.Fixed3D;
        }

            private void pnlGrid_Paint(object sender, PaintEventArgs e)
            {

            }

        private void btn_startingpoint_Click(object sender, EventArgs e)
        {

        }

        private void btn_endingpoint_Click(object sender, EventArgs e)
        {

        }

        private void btn_shortestpath_Click(object sender, EventArgs e)
        {

        }

        private void btn_startbutton_Click_1(object sender, EventArgs e)
        {
            Maze maze = new Maze();
            maze.GenerateMaze();
        }
    }
}
