using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CaveRescue
{
    public partial class frmMainForm : Form
    {
        private CavernLocation rescuePartyLocation = null; 
        private CavernLocation emergancyLocation = null;

        private CavernLocation selectedCaveLocation = null;

        private string[,] caveLocations = null;

        public frmMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMaps();
        }

        private void LoadMaps()
        {
            cbxCavern.Items.Clear();

            foreach (String file in Directory.EnumerateFiles(Path.Combine(Application.StartupPath, "maps")))
            {
                FileInfo fi = new FileInfo(file);
                cbxCavern.Items.Add(fi.Name);
            }

            cbxCavern.SelectedIndex = 0;
        }

        private void Setup(string mapFile)
        {
            pnlCaveLocations.Controls.Clear();

            caveLocations = LoadCavernMap(mapFile);

            // Fill the panel with the number of required squares.
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    CavernLocation location = new CavernLocation();

                    // X = CaveWall, W = Water, V = Vegitation
                    if (caveLocations[j, i] == "X")
                    {
                        location.DefaultColour = Color.Black;
                        location.BackColor = Color.Black;
                        location.LocationTypeText = "Cave Wall";
                    }
                    else if (caveLocations[j, i] == "W") // Just a demonstration of how we can flag other coloured gridspaces (that do nothing).
                    {
                        location.DefaultColour = Color.Blue;
                        location.BackColor = Color.Blue;
                        location.difficultyWeighting = 5;
                        location.LocationTypeText = "Stone Scramble";
                    }
                    else if (caveLocations[j, i] == "V") // Just a demonstration of how we can flag other coloured gridspaces (that do nothing).
                    {
                        location.DefaultColour = Color.Green;
                        location.BackColor = Color.Green;
                        location.difficultyWeighting = 2;
                        location.LocationTypeText = "Vegitation";
                    }

                    // These are the co-ordinates for the grid space
                    location.LocationX = j;
                    location.LocationY = i;

                    location.Click += Location_Click; 
                    location.Location = new Point(j * 30, i * 30);
                    pnlCaveLocations.Controls.Add(location); 
                }
            }
        }

        private string[,] LoadCavernMap(string mapLocation)
        {
            string[,] loadedCavern = new string[25, 15];

            StreamReader reader = new StreamReader(@"maps\" + mapLocation);

            int ln = 0;
            while(!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');

                for (int i = 0; i < parts.Length -1; i++)
                {
                    loadedCavern[i, ln] = parts[i];
                }

                ln ++;
            }

            reader.Close();
            return loadedCavern;
        }

        private void Location_Click(object sender, EventArgs e)
        {
            if (selectedCaveLocation != null)
            {
                selectedCaveLocation.RemoveHighlight();
            }

            selectedCaveLocation = (CavernLocation)sender;
            selectedCaveLocation.Highlight();

            lblSelectedType.Text = "Type: " + selectedCaveLocation.LocationTypeText;
            lblSelectedTime.Text = "Est Time: " + (selectedCaveLocation.difficultyWeighting * 7).ToString() + " minutes";
        }

        private void ClearAllGridSpaceColours()
        {
            foreach (CavernLocation square in pnlCaveLocations.Controls)
                square.Reset();
        }

        private void btnSetRescueParty(object sender, EventArgs e)
        {
            if (rescuePartyLocation != null)
                rescuePartyLocation.Reset();

            if (selectedCaveLocation != null)
            {
                rescuePartyLocation = selectedCaveLocation;
                selectedCaveLocation.Emergancy();
            }
        }

        private void btnSetEmergancy(object sender, EventArgs e)
        {
            if (emergancyLocation != null)
                emergancyLocation.Reset();

            if (selectedCaveLocation != null)
            {
                emergancyLocation = selectedCaveLocation;
                selectedCaveLocation.Emergancy();
            }
        }

        private void btnFindFastestRoute(object sender, EventArgs e)
        {
            int rescuePartyX = rescuePartyLocation.LocationX;
            int rescuePartyY = rescuePartyLocation.LocationY;
            int emergancyX = emergancyLocation.LocationX;
            int emergancyY = emergancyLocation.LocationY;

            CavernLocation endingCavernLocation = FindPathUsingAStar(caveLocations, rescuePartyX, rescuePartyY, emergancyX, emergancyY);
            Stack<CavernLocation> pathFromStartToEnd = new Stack<CavernLocation>();

            while (endingCavernLocation.LocationX != rescuePartyX || endingCavernLocation.LocationY != rescuePartyY)
            {
                pathFromStartToEnd.Push(endingCavernLocation);
                endingCavernLocation = endingCavernLocation.ParentSpace;
            }

            pathFromStartToEnd.Push(endingCavernLocation);

            int locations = 0;
            int difficulty = 0;
            while (pathFromStartToEnd.Count > 0)
            {
                CavernLocation RescueRouteLocation = pathFromStartToEnd.Pop();
                RescueRouteLocation.Highlight(true);
                locations++;
                difficulty += RescueRouteLocation.difficultyWeighting;
            }

            lblLocations.Text = "Total Locations: " + locations.ToString();
            lblRescueTime.Text = "Estimated Rescue Time: " + (difficulty * 7).ToString() + " minutes";
        }

        public CavernLocation GetGridSpaceGivenXandY(int x, int y)
        {
            CavernLocation cavernOnForm = (CavernLocation)pnlCaveLocations.GetChildAtPoint(new Point(x * CavernLocation.LOCATIONHEIGHT, y * CavernLocation.LOCATIONWIDTH));
            return cavernOnForm;
        }

        private KeyValuePair<string, CavernLocation> FindSmallestWeighting(Dictionary<string, CavernLocation> gridSpaceList)
        {
            KeyValuePair<string, CavernLocation> smallestWeighted = gridSpaceList.ElementAt(0);

            foreach (KeyValuePair<string, CavernLocation> item in gridSpaceList)
            {
                if (item.Value.totalweighting < smallestWeighted.Value.totalweighting)
                {
                    smallestWeighted = item;
                }
                else if ((item.Value.totalweighting == smallestWeighted.Value.totalweighting) && (item.Value.to < smallestWeighted.Value.to))
                {
                    smallestWeighted = item;
                }
            }

            return smallestWeighted;
        }

        /// Algorithm adapted from https://stackoverflow.com/questions/2138642/how-to-implement-an-a-algorithm
        private CavernLocation FindPathUsingAStar(string[,] matrix, int fromX, int fromY, int toX, int toY)
        {
            Dictionary<string, CavernLocation> unvisitedNodes = new Dictionary<string, CavernLocation>(); 
            Dictionary<string, CavernLocation> visitedNode = new Dictionary<string, CavernLocation>();
            CavernLocation startingLocation = GetGridSpaceGivenXandY(fromX, fromY); 

            string key = startingLocation.LocationX.ToString() + startingLocation.LocationX.ToString();
            unvisitedNodes.Add(key, startingLocation);

            List<KeyValuePair<int, int>> neighbours = new List<KeyValuePair<int, int>>();
            neighbours.Add(new KeyValuePair<int, int>(-1, 0));
            neighbours.Add(new KeyValuePair<int, int>(0, 1));
            neighbours.Add(new KeyValuePair<int, int>(1, 0));
            neighbours.Add(new KeyValuePair<int, int>(0, -1));

            int maxX = matrix.GetLength(0) -1;
            int maxY = matrix.GetLength(1) -1;

            if (maxX == 0)
            { 
                return null;
            }

            while (true)  
            {
                if (unvisitedNodes.Count == 0)
                {
                    return null;
                }

                KeyValuePair<string, CavernLocation> current = FindSmallestWeighting(unvisitedNodes);

                if (current.Value.LocationX == toX && current.Value.LocationY == toY)
                {
                    return current.Value;
                }

                unvisitedNodes.Remove(current.Key);
                visitedNode.Add(current.Key, current.Value);

                foreach (KeyValuePair<int, int> plusXY in neighbours)
                {
                    int nextX = current.Value.LocationX + plusXY.Key;
                    int nextY = current.Value.LocationY + plusXY.Value;
                    string nextWeighting = nextX.ToString() + nextY.ToString();

                    if (nextX < 0 || nextY < 0 || nextX >= maxX || nextY >= maxY || visitedNode.ContainsKey(nextWeighting) || matrix[nextX,nextY] == "X")
                        continue; 

                    if (unvisitedNodes.ContainsKey(nextWeighting))
                    {
                        CavernLocation currentSpace = unvisitedNodes[nextWeighting];
                        int from = (Math.Abs(nextX - fromX) + Math.Abs(nextY - fromY)) * currentSpace.difficultyWeighting;

                        if (from < currentSpace.from)
                        {
                            currentSpace.from = from;
                            currentSpace.totalweighting = currentSpace.from + currentSpace.to;
                            currentSpace.ParentSpace = current.Value;
                        }
                    }
                    else 
                    {
                        CavernLocation currentSpace = GetGridSpaceGivenXandY(nextX, nextY);

                        currentSpace.from = (Math.Abs(nextX - fromX) + Math.Abs(nextY - fromY)) * currentSpace.difficultyWeighting;
                        currentSpace.to = (Math.Abs(nextX - toX) + Math.Abs(nextY - toY)) * currentSpace.difficultyWeighting;
                        currentSpace.totalweighting = currentSpace.from + currentSpace.to;
                        currentSpace.ParentSpace = current.Value;
                        unvisitedNodes.Add(nextWeighting, currentSpace);
                    }
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ClearAllGridSpaceColours();
            Setup(cbxCavern.Items[cbxCavern.SelectedIndex].ToString());
        }
    }
}
