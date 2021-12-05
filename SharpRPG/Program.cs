using System;
using System.IO;
namespace SharpRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.Init();
            
        }
    }

    public static class Game
    {
        private static readonly string FILE_PATH;
        public const string FILE_NAME = "world.txt";
        private const int WIDTH = 16;
        private const int HEIGHT = 16;
        private static Tile[,] world;
        public static Player player;
        static Game()
        {
            FILE_PATH = @$"{Path.GetDirectoryName(Environment.CurrentDirectory)}\{FILE_NAME}";
            string contents = File.ReadAllText(FILE_PATH);
            Console.WriteLine(contents);
            world = WorldParser.Parse(contents, WIDTH, HEIGHT);
        }

        public static void Init()
        {

        }

    }
    public static class WorldParser
    {
        public static Tile[,] Parse(string input, int width, int height)
        {
            Tile[,] result = new Tile[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int index = width * x + y;
                    char c = input[index];
                    switch (c)
                    {
                        case ' ':
                            result[x, y] = default;
                            break;
                        case '@':
                            result[x, y] = new Enemy(new Coord(x, y), "Skeleton", "Spooky", 10, 3);
                            break;
                        case 'P':
                            Game.player = new Player(new Coord(x, y));
                            break;
                        default:
                            break;
                    }

                }
            }


            return result;
        }
    }
}
