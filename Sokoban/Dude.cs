

using System.Numerics;

namespace Sokoban;
// arv till tiles
// skapa movement metod
// skapa moveleft/right/up/down
// skapa collisionrec bool
// se till att man inte kan go in i andra tiles
public class Dude : Tile
{
   
     public Dude(int x, int y) : base(x, y)
    {
    }  
    
    public Vector2 Movement;
    public void update()
    {
        Movement.X = 0;
        Movement.Y = 0;

         if (Raylib.IsKeyDown(KeyboardKey.Left))
        {
            
            Movement.X--;

        }
        else if (Raylib.IsKeyDown(KeyboardKey.Right))
        {
            
            Movement.X++;

        }

         if (Raylib.IsKeyDown(KeyboardKey.Up))
        {
            Movement.Y--;
        }
        else if (Raylib.IsKeyDown(KeyboardKey.Down))
        {
            Movement.Y++;
    
        }
        rect.X += Movement.X;
        rect.Y += Movement.Y;
    }

    public void moveright(int direction)
    {
       
    }
    public void moveup(int direction)
    {
        
    }
    public void movement()
    {
        
    }
}

