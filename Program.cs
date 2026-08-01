namespace txtRpgCS.Src.root;

using System;
using txtRpgCS.Src.Chunk;
using txtRpgCS.Src.Tile;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false;
        Console.Clear();

        Chunk currentChunk = new Chunk(0, 0);

        int playerX = 2;
        int playerY = 1;

        while (true)
        {
            Console.SetCursorPosition(0, 0);

            ConsoleColor lastColor = ConsoleColor.Black;

            for (int y = 0; y < Chunk.Height; y++)
            {
                for (int x = 0; x < Chunk.Width; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        if (lastColor != ConsoleColor.Yellow)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            lastColor = ConsoleColor.Yellow;
                        }
                        Console.Write('@');
                    }
                    else
                    {
                        Tile tile = currentChunk.Map[x, y];

                        (ConsoleColor color, char symbol) = tile.Type switch
                        {
                            TileType.Grass => (ConsoleColor.Green, '.'),
                            TileType.Stone => (ConsoleColor.DarkGray, '#'),
                            TileType.Water => (ConsoleColor.Blue, '~'),
                            TileType.Dirt => (ConsoleColor.DarkYellow, ':'),
                            _ => (ConsoleColor.White, ' ')
                        };

                        if (color != lastColor)
                        {
                            Console.ForegroundColor = color;
                            lastColor = color;
                        }

                        Console.Write(symbol);
                    }
                }
                Console.WriteLine();
            }

            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            ConsoleKeyInfo key = Console.ReadKey(true);

            int nextX = playerX;
            int nextY = playerY;

            if (key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow) nextY--;
            if (key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow) nextY++;
            if (key.Key == ConsoleKey.A || key.Key == ConsoleKey.LeftArrow) nextX--;
            if (key.Key == ConsoleKey.D || key.Key == ConsoleKey.RightArrow) nextX++;
            if (key.Key == ConsoleKey.Escape) break;

            Tile targetTile = currentChunk.Map[nextX, nextY];
            if (!targetTile.IsSolid)
            {
                playerX = nextX;
                playerY = nextY;
            }
        }
    }
}