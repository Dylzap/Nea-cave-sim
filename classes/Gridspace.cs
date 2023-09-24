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
   
         public int FromWeighting { get; set; }
         public int ToWeighting { get; set; }
         public int SumWeight { get; set; }

         public int GridX { get; set; }
         public int GridY { get; set; }
        
        public bool cellvisited = false;

         Random randomcell = new Random();
         List<Gridspace> AdjacentCellsList = new List<Gridspace>();
        Gridspace adjacentcell = new Gridspace();
        Gridspace currentcell = new Gridspace();
        Gridspace wall = new Gridspace();
        Stack<Gridspace> Adjacentcellstack = new Stack<Gridspace>();
        Gridspace connectwalls1 = new Gridspace();
        Gridspace connectwalls2 = new Gridspace();
        Gridspace connectwalls3 = new Gridspace();
        Gridspace connectwalls4 = new Gridspace();
        Gridspace Randomcell = new Gridspace();
        bool iswallconnected = false;


        public void Findadajacentcells()
        {

            currentcell.GridX = 0;
            currentcell.GridY = 0;
            Adjacentcellstack.Push(currentcell);

            while (currentcell.cellvisited == false)
            {


                adjacentcell.GridX = currentcell.GridX + 1;

                if (adjacentcell.cellvisited == false)
                {

                    AdjacentCellsList.Add(adjacentcell);
                  
                    adjacentcell.cellvisited = true;



                }

                adjacentcell.GridX = currentcell.GridX - 1;

                if (adjacentcell.cellvisited == false)
                {

                    AdjacentCellsList.Add(adjacentcell);
                   
                    adjacentcell.cellvisited = true;



                }

                adjacentcell.GridY = currentcell.GridY + 1;

                if (adjacentcell.cellvisited == false)
                {

                    adjacentcell.cellvisited = true;
                    AdjacentCellsList.Add(adjacentcell);
                   

                }
                adjacentcell.GridY = currentcell.GridY - 1;

                if (adjacentcell.cellvisited == false)
                {

                    AdjacentCellsList.Add(adjacentcell);
                   
                    adjacentcell.cellvisited = true;

                }

            }

        }
       
        public void Diagonalladjacentwall()
        {
            if (iswallconnected == true)
            {
                connectwalls1.GridX = currentcell.GridX - 1;
                connectwalls1.GridY = currentcell.GridY - 1;

                connectwalls2.GridX = currentcell.GridX - 1;
                connectwalls2.GridY = currentcell.GridY + 1;

                connectwalls3.GridX = currentcell.GridX + 1;
                connectwalls3.GridY = currentcell.GridY + 1;

                connectwalls4.GridX = currentcell.GridX + 1;
                connectwalls4.GridY = currentcell.GridY - 1;

                AdjacentCellsList.Add(connectwalls1);
                
                AdjacentCellsList.Add(connectwalls2);
               

                AdjacentCellsList.Add(connectwalls3);
               

                AdjacentCellsList.Add(connectwalls4);
                
                

                //iterate through list if the cells have been visited or is a wall or when wall is generated put the walls as visited 
            }


        }
        public void Getrandomwall()
        {

            int rng = randomcell.Next(0, AdjacentCellsList.Count());

            //AdjacentCellsList.ElementAt(rng).BackColor = Color.Brown;
            //wall = AdjacentCellsList.ElementAt(rng);

           
            Adjacentcellstack.Pop();
            Adjacentcellstack.Prepend(AdjacentCellsList.ElementAt(rng));

            foreach (Gridspace adjacentcell in AdjacentCellsList)
            {
                if (adjacentcell != Adjacentcellstack.Prepend(AdjacentCellsList.ElementAt(rng)))
                {
                    wall = adjacentcell;
                    Adjacentcellstack.Push(adjacentcell);
                    
                }
            }

            if (connectwalls1 != AdjacentCellsList.ElementAt(rng))
            {
                connectwalls1 = wall;
                Adjacentcellstack.Push(connectwalls2);

            }
            if (connectwalls2 != AdjacentCellsList.ElementAt(rng))
            {
                connectwalls2 = wall;
                Adjacentcellstack.Push(connectwalls2);
            }
            if (connectwalls3 != AdjacentCellsList.ElementAt(rng))
            {
                connectwalls3 = wall;
                Adjacentcellstack.Push(connectwalls3);
            }
            if (connectwalls4 != AdjacentCellsList.ElementAt(rng))
            {
                connectwalls4 = wall;
                Adjacentcellstack.Push(connectwalls4);
            }

            wall.BackColor = Color.Brown;
            currentcell.cellvisited = true;
        }

        

    }
}
