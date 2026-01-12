

using System.Drawing;
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

    
    
    
    // Denna metod uppdaterar efter varje frame inom spelet
    public void update()
    {   
        


        // Detta är variabler för att flytta spelaren inom spelet
        Movement.X = 0;
        Movement.Y = 0;
        // Dessa if satser är för att att ändra på X- och Y-positionerna av spelarna
         if (Raylib.IsKeyPressed(KeyboardKey.Left) )
        {
            // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning
            Movement.X-= size;

           


        }
    
        else if (Raylib.IsKeyPressed(KeyboardKey.Right)  )
        {
            
            Movement.X+= size;

            

        }

         if (Raylib.IsKeyPressed(KeyboardKey.Up))
        {
            Movement.Y-= size;
           

        }
        else if (Raylib.IsKeyPressed(KeyboardKey.Down)   )
        {
            Movement.Y+= size;
        
    
        }
        rect.X += Movement.X ;
        rect.Y += Movement.Y ;
    }

   
}

