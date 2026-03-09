
using System.Numerics;

// detta är en basklass för alla typer av rutor inom spelet
public class Tile
{
// Detta är en lista som innehåller alla typer av rutor som skapas
    static public List<Tile> tiles = [];

    public Rectangle rect;
    // Detta är storleken på en ruta
    public int size = 100;

    public Color color;

    
// Detta är konstruktorn som lägger till varje ruta som skapas inom listan och 
// även ger rutan sin storlek och sin position inom rutnätet
    public Tile(int x, int y)
    {
        tiles.Add(this);
        rect = new(x * size, y * size, size , size);
    }

    


}
