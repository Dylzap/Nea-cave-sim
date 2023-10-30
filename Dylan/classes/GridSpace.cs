using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEA__cave_rescue_simulator
{
    public class GridSpace : Label
    {
        public const int GRID_SPACE_WIDTH = 20;
        public const int GRID_SPACE_HEIGHT = 20;
        public int GridX = 0;
        public int GridY = 0;

        public bool isSelected = false;
        public bool isWallpresent = false;
        public bool cellvisited = false;

        public GridSpace()
        {
            this.AutoSize = false;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void ClickedOn()
        {
            if (isSelected)
            {
                //Deselect
                this.BorderStyle = BorderStyle.FixedSingle;
                this.BackColor = Color.White;
                this.Text = "";
                isSelected = false;
            }
            else
            {
                this.BorderStyle = BorderStyle.Fixed3D;
                this.BackColor = Color.Yellow;
                this.Text = "C";
                isSelected = true;
            }
        }
        
    }
}
