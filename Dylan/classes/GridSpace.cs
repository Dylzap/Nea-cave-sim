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
    public class GridSpace : Panel
    {
        public const int GRID_SPACE_WIDTH = 20;
        public const int GRID_SPACE_HEIGHT = 20;

        public int Fromweightingcost = 0;
        public int Toweightingcost = 0;
        public int Totalweightingcost = 0;

        public int GridX = 0;
        public int GridY = 0;

        public bool isSelected = false;   
        public bool iswall {get; set;}

        public GridSpace()
        {
            this.AutoSize = false;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void Cellclickedon()
        {    
                this.BorderStyle = BorderStyle.Fixed3D;
                this.BackColor = Color.Yellow;
                this.Text = "C";
                isSelected = true;         
        }
        public void Deselectcell()
        {
            //Deselect
            this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.Text = "";
            isSelected = false;


        }

        public void Highlightcell()
        {
            this.BackColor = Color.Yellow;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

    }
}
