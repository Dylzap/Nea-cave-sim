using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaveRescue
{
    public partial class btn : Form
    {
        public btn()
        {
            InitializeComponent();
        }

        CavernLocation cavernlocation = new CavernLocation();  
        private CavernLocation selectedCaveLocation = null;
        private string[,] caveLocations = null;

      
        private void btn_addobject_Click(object sender, EventArgs e)
        {
            Addobjectfrm addobjectfrm = new Addobjectfrm();
            addobjectfrm.Show();
        }

        private void btn_makegrid_Click(object sender, EventArgs e)
        {
           
            Generategrid();
        }

 

        public void Generategrid()
        {
            pnl_Cavern.Controls.Clear();
            caveLocations = LoadCavernMap();

            // Fill the panel with the number of required squares.
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    CavernLocation location = new CavernLocation();
                   
                        if (caveLocations[j, i] == "W")
                        {
                            location.DefaultColour = Color.White;
                            location.BorderStyle = BorderStyle.FixedSingle;
                            location.BackColor = Color.White;
                            location.LocationTypeText = "Empty space ";
                        }
                    
                    // These are the co-ordinates for the grid space
                    location.LocationX = j;
                    location.LocationY = i;

                    location.Click += Location_Click;
                    location.Location = new Point(j * 30, i * 30);
                    pnl_Cavern.Controls.Add(location);
                }
            }

        }
        private void Location_Click(object sender, EventArgs e)
        {
            if (selectedCaveLocation != null)
            {
                selectedCaveLocation.RemoveHighlight();
            }

            selectedCaveLocation = (CavernLocation)sender;
            selectedCaveLocation.Highlight();

            
        }
        private string[,] LoadCavernMap()
        {
            string[,] loadedCavern = new string[25, 15];

            StreamReader reader = new StreamReader(@"maps\\" + "Usergeneratedcavern.txt") ;

            int ln = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                for (int i = 0; i < parts.Length - 1; i++)
                {
                    loadedCavern[i, ln] = parts[i];
                }

                ln++;
            }

            reader.Close();
            return loadedCavern;
        }

    }
}
