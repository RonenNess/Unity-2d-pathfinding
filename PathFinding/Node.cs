namespace PathFind
{
    /**
    * A node in the grid map
    */
    public class Node
    {
        // node starting params
        public bool walkable;
        public int gridX;
        public int gridY;
        public float penalty;

        // calculated values while finding path
        public int gCost;
        public int hCost;
        public Node parent;

        // create the node
        // _price - how much does it cost to pass this tile. less is better, but 0.0f is for non-walkable.
        // _gridX, _gridY - tile location in grid.
        public Node(float _price, int _gridX, int _gridY)
        {
            walkable = _price != 0.0f;
            penalty = _price;
            gridX = _gridX;
            gridY = _gridY;
        }

        public int fCost
        {
            get
            {
                return gCost + hCost;
            }
        }
    }
}