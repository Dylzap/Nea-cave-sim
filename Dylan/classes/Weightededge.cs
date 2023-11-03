using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEA__cave_rescue_simulator.classes
{
    public class Weightededge
    {
        int weight;

        Vertex start;
        Vertex end;

        public int Weight { get { return weight; } }

        public Vertex Start { get { return start; } }
        public Vertex End { get { return end; } }

        public WeightedEdge(Vertex start, Vertex end, int weight)
        {
            this.start = start;
            this.end = end;
            this.weight = weight;
            start.AddNeighbor(end);
            start.AddEdge(this);

        }


    }
}
