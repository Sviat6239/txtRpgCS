using System;

class Tile
{
    public int x;
    public int y;

    public string TerrainType;
    public string Biom;

    public Tile(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

class World
{
    public int height;
    public int width;
    public Tile[,] worldmap;

    public World(int height, int width)
    {
        this.height = height;
        this.width = width;
        this.worldmap = new Tile[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                worldmap[i, j] = new Tile(i, j);
            }
        }
    }
}