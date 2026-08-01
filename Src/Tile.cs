namespace txtRPG.src.Tile;

public enum TileType
{
    Air,
    Grass,
    Dirt,
    Stone,
    Cobblestone,
    Water,

}

public class Tile
{
    public TileType type { get; set; }
    public int Hp { get; set; }
    public int CordX { get; set; }
    public int CordY { get; set; }
    public bool IsSolid { get; set; }
    public bool IsBreakable { get; set; }

    public Tile(TileType type, int x, int y)
    {
        Type = type;
        CordX = x;
        CordY = y;

        switch (type)
        {
            case TileType.Air:
                Hp = 0;
                IsSolid = false;
                break;
            case TileType.Grass:
                Hp = 2;
                IsSolid = false;
                IsBreakable = false;
                break;
            case TileType.Dirt:
                Hp = 2;
                IsSolid = true;
                IsBreakable = true;
                break;
            case TileType.Stone:
                Hp = 5;
                IsSolid = true;
                IsBreakable = true;
                break;
            case TileType.Cobblestone:
                Hp = 4;
                IsSolid = true;
                IsBreakable = true;
                break;
            case TileType.Water:
                Hp = 0;
                IsSolid = false;
                IsBreakable = false;
        }
    }
}