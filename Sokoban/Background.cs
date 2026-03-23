/*
Vägg
Golv
Golv med vinstplats
Låda
Gubbe
*/

using System.Security.Cryptography.X509Certificates;
using Sokoban;

public class Background
{
    // Detta är själva rutnätet som är för rutor som inte har någon rörelse som väggar och golv
    public Tile[,] grid = new Tile[9, 7];

    // Detta är själva rutnätet som är för rutor som har rörelse som spelaren och lådor
    public Tile[,] BoxGrid = new Tile[9, 7];

    // Detta är en konstruktor för bakgrunden, alltså körs det vid en ny instans av en bakgrund.
    public Background()
    {



        for (int y = 0; y < grid.GetLength(1); y++)
        {
            // Den inre loopen här körs en gång per unik position i 
            // den tvådimensionella arrayen, och variablerna x och y 
            // har index-värdena för den aktuella positionen.
            for (int x = 0; x < grid.GetLength(0); x++)
            {

                grid[x, y] = new Floor(x, y); // Ändrar alla positioners värde till 4.

                // Ändrar alla positioner som är "längst till höger" i rutnätet till 2.
                // if (x == 0)
                // {
                //     grid[x, y] = 2;
                // }
            }
        }

        for (int y = 0; y < grid.GetLength(1); y++)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                if (x == 0 || y == 0 || x == grid.GetLength(0) - 1 || y == grid.GetLength(1) - 1)
                {
                    grid[x, y] = new Wall(x, y);
                }

                // if (x % 2 == 0 && y % 2 == 0)
                // {
                //     grid[x, y] = new Wall(x, y);
                // }
            }
        }

        for (int y = 0; y < BoxGrid.GetLength(1); y++)
        {
            for (int x = 0; x < BoxGrid.GetLength(0); x++)
            {
                BoxGrid[x, y] = new Tile(x, y);
            }
        }

        BoxGrid[4, 3] = new Box(4, 3);






    }

    bool HasWon(Tile[,] bg, Tile[,] bxs)
    {
        for (int y = 0; y < bg.GetLength(0); y++)
        {
            for (int x = 0; x < bg.GetLength(1); x++)
            {
                if (bg[y, x] is Floor_with_Win && bxs[y, x] is Box)
                    {
                    return true;
                }
            }
        }
    }






}
