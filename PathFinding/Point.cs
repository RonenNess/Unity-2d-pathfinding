
namespace PathFind
{
    /**
    * A 2d point on the grid
    */
    public class Point
    {
        public int x;
        public int y;

        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int iX, int iY)
        {
            this.x = iX;
            this.y = iY;
        }

        public Point(Point b)
        {
            x = b.x;
            y = b.y;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }

        public override bool Equals(System.Object obj)
        {
            // Unlikely to compare incorrect type so removed for performance
            // if (!(obj.GetType() == typeof(PathFind.Point)))
            //     return false;
            Point p = (Point)obj;

            if (ReferenceEquals(null, p))
            {
                return false;
            }

            // Return true if the fields match:
            return (x == p.x) && (y == p.y);
        }

        public bool Equals(Point p)
        {
            if (ReferenceEquals(null, p))
            {
                return false;
            }
            // Return true if the fields match:
            return (x == p.x) && (y == p.y);
        }

        public static bool operator ==(Point a, Point b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (ReferenceEquals(null, a))
            {
                return false;
            }
            if (ReferenceEquals(null, b))
            {
                return false;
            }
            // Return true if the fields match:
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }

        public Point Set(int iX, int iY)
        {
            this.x = iX;
            this.y = iY;
            return this;
        }
    }
}
