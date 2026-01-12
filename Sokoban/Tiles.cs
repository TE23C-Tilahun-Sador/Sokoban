
using System.Numerics;

public class Tile
{

    static public List<Tile> tiles = [];
    // public Vector2 Posistion;

    public Rectangle rect;
    public int size = 100;

    

    public Tile(int x, int y)
    {
        tiles.Add(this);
        rect = new(x * size, y * size, size , size);
    }


}
