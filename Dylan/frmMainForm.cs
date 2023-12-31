﻿using NEA__cave_rescue_simulator.classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NEA__cave_rescue_simulator
{
    public partial class frmMainForm : Form
    {
        private string[,] matrix = null;

        private GridSpace lastClickedOnSpace = null;
        public GridSpace Startinglocation = new GridSpace();
        public GridSpace Endinglocation = new GridSpace();
        public Pathfinder Astar = new Pathfinder();

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
                    newGridSpace.Click += NewGridSpace_Click;


                    pnlGridPanel.Controls.Add(newGridSpace); 
                }
            }
        }

        private void NewGridSpace_Click(object sender, EventArgs e)
        {
            lastClickedOnSpace = ((GridSpace)sender);
            lastClickedOnSpace.Cellclickedon();
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
            if (Startinglocation != null)
            {
                Startinglocation.Deselectcell();
            }

            if (lastClickedOnSpace != null)
            {
                Startinglocation = lastClickedOnSpace;
                lastClickedOnSpace.BackColor = Color.Red;
            }
        }

        private void btn_endingpoint_Click(object sender, EventArgs e)
        {
            if (Endinglocation != null)
            {
                Endinglocation.Deselectcell();
            }

            if (lastClickedOnSpace != null)
            {
                Endinglocation = lastClickedOnSpace;
                lastClickedOnSpace.BackColor = Color.Red;
            }
        }

        private void btn_shortestpath_Click(object sender, EventArgs e)
        {
            Node start = new Node(4, 0);
            Node end = new Node(4, 4);

            List<Node> path = AStar.FindPath(maze, start, end);


            

        }

        private void btn_startbutton_Click_1(object sender, EventArgs e)
        {
            SetupGridSpaces();
        }
    }
}
