

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

    Background background;

    public Dude(int x, int y, Background b) : base(x, y)
    {
        background = b;
    }

    public Vector2 Movement;


    // Denna metod uppdaterar efter varje frame inom spelet
    public void update()
    {

        int gridX = (int)(rect.X / size);
        int gridY = (int)(rect.Y / size);


        if (gridX <= background.grid.GetLength(0))

            // if (background.grid[gridX, gridY] is Floor)
            // {

            // }


            // System.Console.WriteLine(gridX);

            // Detta är variabler för att flytta spelaren inom spelet
            Movement.X = 0;
        Movement.Y = 0;
        // Dessa if satser är för att att ändra på X- och Y-positionerna av spelarna
        if (Raylib.IsKeyPressed(KeyboardKey.Left))
        {
            // Detta ser till att rutan där bredvid inte är en vägg
            if (background.grid[gridX - 1, gridY] is Floor)
            {
                
                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

                Movement.X -= size;
            }

        }

        else if (Raylib.IsKeyPressed(KeyboardKey.Right) && gridX <= background.grid.GetLength(0))
        {
            if (background.grid[gridX + 1, gridY] is Floor)
            {
                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

            Movement.X += size;
                
            }

        }
        else
        {
            Movement.X = 0;
        }

        if (Raylib.IsKeyPressed(KeyboardKey.Up))
        {
             if (background.grid[gridY - 1, gridX] is Floor)
            {
                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

            
            Movement.Y -= size;
                
            }



        }
        else if (Raylib.IsKeyPressed(KeyboardKey.Down))
        {
             if (background.grid[gridX, gridY + 1] is Floor)
            {
                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

            
            Movement.Y += size;
                
            }

            


        }
        rect.X += Movement.X;
        rect.Y += Movement.Y;
    }


}

