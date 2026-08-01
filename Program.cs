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

            for (int y = 0; y < Chunk.Height; y++)
            {
                for (int x = 0; x < Chunk.Width; x++)
                {
                    if (x == playerX && y == playerY)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write('@');
                    }
                    else
                    {
                        Tile tile = currentChunk.Map[x, y];

                        switch (tile.Type)
                        {
                            case TileType.Grass:
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write('.');
                                break;
                            case TileType.Stone:
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write('#');
                                break;
                            case TileType.Water:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.Write('~');
                                break;
                            case TileType.Dirt:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Write(':');
                                break;
                            case TileType.Air:
                                Console.Write(' ');
                                break;
                        }
                    }
                }
                Console.WriteLine();
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