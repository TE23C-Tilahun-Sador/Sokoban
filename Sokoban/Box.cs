using Raylib_cs;

namespace Sokoban;

public class Box : Tile
{
    public Box(int x, int y) : base(x, y)
    {
        color = Color.Brown;                                                    
    }
}
