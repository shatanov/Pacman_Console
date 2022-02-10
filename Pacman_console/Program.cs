using System.IO;

namespace Pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            int pacmanX, pacmanY;
            char[,] map = ReadMap("map", out pacmanX, out pacmanY);
            DrawMap(map);
        }

        static void DrawMap(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        static char[,] ReadMap(string mapName, out int pacmanX, out int pacmanY)
        {
            pacmanX = 0;
            pacmanY = 0;
            string[] mapFile = File.ReadAllLines($"../../../maps/{mapName}.txt");
            char[,] map = new char[mapFile.Length, mapFile[0].Length];
            int x = mapFile[1].Length;
            int x1 = mapFile[0].Length;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = mapFile[i][j];
                    if (map[i, j] == '@')
                    {
                        pacmanX = i;
                        pacmanY = j;
                        map[i, j] = ' ';
                    }
                }
            }

            return map;
        }
    }
};

