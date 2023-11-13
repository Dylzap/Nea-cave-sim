using System.Drawing;
using System.Windows.Forms;

namespace CaveRescue
{
    public class CavernLocation : Label
    {
        public CavernLocation ParentSpace;

        public Color DefaultColour = Color.DarkGray;
        public Color SelectedColour = Color.Yellow;
        public Color EmergancyColor = Color.Red;


        public const int LOCATIONWIDTH = 30;
        public const int LOCATIONHEIGHT = 30;

        public int from;
        public int to;
        public int totalweighting;
        public int difficultyWeighting = 1;

        public int LocationX;
        public int LocationY;

        private bool IsEmergancyLocation = false;

        public string LocationTypeText = "Stone Scramble";

        public CavernLocation()
        {
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font(FontFamily.GenericSansSerif, 10f, FontStyle.Bold);

            this.Width = LOCATIONWIDTH;
            this.Height = LOCATIONHEIGHT;
            this.BackColor = this.DefaultColour;
        }

        public void Highlight(bool placeX = false)
        {
            this.BackColor = this.SelectedColour;

            if (placeX == true)
                this.Text = "X";
        }

        public void Emergancy()
        {
            this.BackColor = this.EmergancyColor;
            this.IsEmergancyLocation = true;
        }

        public void RemoveHighlight()
        {
            if (!IsEmergancyLocation)
                this.BackColor = this.DefaultColour;
        }

        public void Reset()
        {
            this.BackColor = this.DefaultColour;
        }
    }
}
