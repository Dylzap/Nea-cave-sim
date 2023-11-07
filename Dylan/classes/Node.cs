namespace NEA__cave_rescue_simulator.classes
{
    public class Node
    {
        public int X { get; }
        public int Y { get; }
        public Node Parent { get; set; }
        public int G { get; set; }
        public int H { get; set; }

        public Node(int x, int y)
        {
            X = x;
            Y = y;
            G = 0;
            H = 0;
            Parent = null;
        }

        public int F
        {
            get { return G + H; }
        }

    }
}