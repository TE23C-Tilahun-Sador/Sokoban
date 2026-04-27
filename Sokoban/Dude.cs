
using System.Numerics;
using Sokoban;

public class Dude : Tile
{

    Background background;

    public bool Won;

    public Dude(int x, int y, Background b) : base(x, y)
    {
        background = b;
    }

    public Vector2 Movement;


    // Denna metod uppdaterar efter varje frame inom spelet
    public void update()
    {
        // Dessa variablar är spelarens X och Y axel
        int gridX = (int)(rect.X / size);
        int gridY = (int)(rect.Y / size);


            // Detta är variabler för att flytta spelaren inom spelet
            Movement.X = 0;
            Movement.Y = 0;
        // Dessa if satser är för att att ändra på X- och Y-positionerna av spelarna
        if (Raylib.IsKeyPressed(KeyboardKey.Left))
        {
            if (background.BoxGrid[gridX - 1, gridY] is Box && background.grid[gridX - 2, gridY] is not Wall)
            {
                // flytta göbben
                background.BoxGrid[gridX - 2, gridY] = background.BoxGrid[gridX - 1, gridY];
                background.BoxGrid[gridX - 2, gridY].rect.X -= size;
                background.BoxGrid[gridX - 1, gridY] = new Tile(0, 0);

                  Movement.X -= size;
            }

            // Detta ser till att rutan där bredvid inte är en vägg
            else if (background.grid[gridX - 1, gridY] is not Wall && background.BoxGrid[gridX - 1, gridY] is not Box )
            {

                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

                Movement.X -= size;
            }

        }

        else if (Raylib.IsKeyPressed(KeyboardKey.Right) )
        {
            if (background.BoxGrid[gridX + 1, gridY] is Box && background.grid[gridX + 2, gridY] is not Wall)
            {
                // flytta göbben
                background.BoxGrid[gridX + 2, gridY] = background.BoxGrid[gridX + 1, gridY];
                background.BoxGrid[gridX + 2, gridY].rect.X += size;
                background.BoxGrid[gridX + 1, gridY] = new Tile(0, 0);

                  Movement.X += size;
            }

            // Detta ser till att rutan där bredvid inte är en vägg
            else if (background.grid[gridX + 1, gridY] is not Wall && background.BoxGrid[gridX + 1, gridY] is not Box )
            {

                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

                Movement.X += size;
            }
           

        }


        if (Raylib.IsKeyPressed(KeyboardKey.Up))
        {
            if (background.BoxGrid[gridX, gridY - 1] is Box && background.grid[gridX, gridY - 2] is not Wall)
            {
                // flytta göbben
                background.BoxGrid[gridX, gridY - 2] = background.BoxGrid[gridX, gridY - 1];
                background.BoxGrid[gridX, gridY - 2].rect.Y -= size;
                background.BoxGrid[gridX, gridY - 1] = new Tile(0, 0);

                Movement.Y -= size;
            }

            // Detta ser till att rutan där bredvid inte är en vägg
            else if (background.grid[gridX, gridY - 1] is not Wall && background.BoxGrid[gridX, gridY - 1] is not Box)
            {

                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

                Movement.Y -= size;
            }
            


        }
        else if (Raylib.IsKeyPressed(KeyboardKey.Down))
        {
            if (background.BoxGrid[gridX, gridY + 1] is Box && background.grid[gridX, gridY + 2] is not Wall)
            {
                // flytta göbben
                background.BoxGrid[gridX, gridY + 2] = background.BoxGrid[gridX, gridY + 1];
                background.BoxGrid[gridX, gridY + 2].rect.Y += size;
                background.BoxGrid[gridX, gridY + 1] = new Tile(0, 0);

                Movement.Y += size;
            }

            // Detta ser till att rutan där bredvid inte är en vägg
            else if (background.grid[gridX, gridY + 1] is not Wall && background.BoxGrid[gridX, gridY + 1] is not Box)
            {

                // spelaren flyttas med en ruta per klick istället för att kontenuerligt flyttas åt en riktning

                Movement.Y += size;
            }
           

        }
        rect.X += Movement.X;
        rect.Y += Movement.Y;
    }


}

