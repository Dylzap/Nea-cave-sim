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
    public class Gridspace : Form
    {
        public const int GRID_SPACE_WIDTH = 20;
        public const int GRID_SPACE_HEIGHT = 20;
        public int GridX = 0;
        public int GridY = 0;

        public bool IsWalkable = false;
        
    }
}
