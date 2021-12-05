namespace SharpRPG
{
    public abstract class Tile
    {
        private string name;
        private string description;
        private Coord position;

        public string Name => name;
        public string Description => description;
        public Coord Position => position;
        public Tile(string name, string description, Coord position)
        {
            this.name = name;
            this.description = description;
            this.position = position;
        }
    }
}
