using System;

namespace SharpRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public abstract class Tile
    {
        private string name;
        private string description;


        public string Name => name;
        public string Description => description;

        public Tile(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
    
}
