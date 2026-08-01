namespace txtRpgCS.Src.Chunk;

using txtRpgCS.Src.Tile;

public class Chunk
{
    public const int Width = 128;
    public const int Height = 48;

    public int CordX { get; set; }
    public int CordY { get; set; }

    public Tile[,] Map = new Tile[Width, Height];

    public Chunk(int x, int y)
    {
        CordX = x;
        CordY = y;

        for (int localX = 0; localX < Width; localX++)
        {
            for (int localY = 0; localY < Height; localY++)
            {
                Map[localX, localY] = new Tile(TileType.Grass, localX, localY);
            }
        }
    }
}