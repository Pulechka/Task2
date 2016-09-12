namespace VectorGraphicsEditor
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Point p = obj as Point;
            if (p == null)
            {
                return false;
            }
            return this == p;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode();
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
       }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.X != p2.X;
        }
    }


}
