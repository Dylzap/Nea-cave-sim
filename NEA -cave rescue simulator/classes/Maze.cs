﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA__cave_rescue_simulator
{
    public class Maze : Gridspace 
    {

        public void GenerateMaze()
        {
            int totalcells = 1200;
            int visitedcells = 0;


            while (visitedcells <= totalcells)
            {

                Diagonalladjacentwall();
                Findadajacentcells();

                if (Finddeadends() == true )
                {
                    Diagonalladjacentwall();
                    Findadajacentcells();

                }
                Getrandomwall();

                visitedcells = visitedcells + 8;

            }



        }

        
    }



}
