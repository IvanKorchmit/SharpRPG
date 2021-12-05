namespace SharpRPG
{
    public struct Coord
    {
        public int x;
        public int y;
        public Coord(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Coord operator +(Coord a, Coord b)
        {
            Coord result = new Coord(a.x + b.x, a.y + b.y);
            return result;
        }
    }
}
