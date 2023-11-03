using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA__cave_rescue_simulator.classes
{
    public class Vertex
    {
        List<Vertex> neighbors;
        List<Weightededge> edges;
       

        public int Nvalue { get; set; }
        public bool Visited { get; set; }
         public int Availableneighbours { get; set; }
         public int Cost { get; set; }

        
        public Vertex(int Nvalue)
        {
            this.Nvalue = Nvalue;
            Visited = false;
             List<Vertex>.Count() = Availableneighbours ;
            edges = new List<WeightedEdge>();
        }

        public Vertex( int Nvalue, List<Vertex> neighbors)
        {
            this.Nvalue = Nvalue;
            Visited = false;
            this.neighbors = neighbors;
        }

        public void AddNeighbor(Vertex vertex)
        {
            neighbors.Add(vertex);
        }
        public void AddEdge(WeightedEdge edge)
        {
            edges.Add(edge);
        }

    }
}
