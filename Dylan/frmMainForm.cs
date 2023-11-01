using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NEA__cave_rescue_simulator
{
    public partial class frmMainForm : Form
    {
        private string[,] matrix = null;
        GridSpace Startingpoint = null;
        GridSpace Selectedcell = null;
        GridSpace Endingpoint = null;


        public frmMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btn_startbutton_Click(object sender, EventArgs e)
        {
           SetupGridSpaces();
        }

        private void SetupGridSpaces()
        {
            matrix = LoadGridMap("Grid.txt"); 
            pnlGridPanel.Controls.Clear(); // Clear the existing panel

            int MazeSquaresHorizontal = pnlGridPanel.Width / GridSpace.GRID_SPACE_WIDTH;
            int MazeSquaresVertical = pnlGridPanel.Height / GridSpace.GRID_SPACE_HEIGHT;

            for (int i = 0; i < MazeSquaresVertical - 1; i++)
            {
                for (int j = 0; j < MazeSquaresHorizontal - 1; j++)
                {
                    GridSpace newGridSpace = new GridSpace();
                    newGridSpace.BackColor = Color.White;
                    newGridSpace.Width = GridSpace.GRID_SPACE_WIDTH;
                    newGridSpace.Height = GridSpace.GRID_SPACE_HEIGHT;

                    if (matrix[i, j] == "X")
                    {
                        newGridSpace.BackColor = Color.Black;
                    }
                    else if (matrix[i, j] == "G") 
                    {
                        newGridSpace.BackColor = Color.Gold;
                    }
                   
                    newGridSpace.GridX = j;
                    newGridSpace.GridY = i;
                    newGridSpace.Location = new Point(j * newGridSpace.Width, i * newGridSpace.Height);
                    newGridSpace.Click += GridSpace_Click;


                    pnlGridPanel.Controls.Add(newGridSpace); 
                }
            }
        }

        private void GridSpace_Click(object sender, EventArgs e)
        {
            if (Selectedcell != null)
            {
                Selectedcell.Deselect();
            }

            Selectedcell = (GridSpace)sender;
            Selectedcell.ClickedOn();
        }


        private string[,] LoadGridMap(string mapLocation)
        {
            string[,] matrixLoaded = new string[pnlGridPanel.Height / GridSpace.GRID_SPACE_HEIGHT, pnlGridPanel.Width / GridSpace.GRID_SPACE_WIDTH];

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
            if (Startingpoint != null)
            {
               Startingpoint.Deselect();
            }

            if (Selectedcell != null)
            {
                Startingpoint = Selectedcell;
                Selectedcell.BackColor = Color.Red;
            }
        }

        private void btn_endingpoint_Click(object sender, EventArgs e)
        {
            if (Endingpoint != null)
            {
                Startingpoint.Deselect();
            }

            if (Selectedcell != null)
            {
                Endingpoint = Selectedcell;
                Endingpoint.BackColor = Color.Green;
            }
        }

        private void btn_shortestpath_Click(object sender, EventArgs e)
        {

        }

        private void btn_startbutton_Click_1(object sender, EventArgs e)
        {
            SetupGridSpaces();
        }
    }
}
