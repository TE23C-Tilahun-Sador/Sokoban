/*
Vägg
Golv
Golv med vinstplats
Låda
Gubbe
*/

using Sokoban;

public class Background
{
    public Tile[,] grid = new Tile[9, 7];

    public void BkgGrid()
    {
        for (int x = 0; x < grid.GetLength(0); x++)
        {
            for (int y = 0; y < grid.GetLength(1); y++)
            {
                new Floor(x, y);

            }
        }

    }

    public Background()
    {



        for (int y = 0; y < grid.GetLength(1); y++)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                // Den inre loopen här körs en gång per unik position i 
                // den tvådimensionella arrayen, och variablerna x och y 
                // har index-värdena för den aktuella positionen.

                grid[x, y] = new Floor(x, y); // Ändrar alla positioners värde till 4.

                // Ändrar alla positioner som är "längst till höger" i rutnätet till 2.
                // if (x == 0)
                // {
                //     grid[x, y] = 2;
                // }
            }
        }
    }

    public void Draw()
    {
        for (int y = 0; y < grid.GetLength(1); y++)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                Console.Write(grid[x, y]); // Ritar ut den nuvarande rutan
            }
            Console.WriteLine(); // Lägger till en radbrytning i slutet på varje utritad rad.
        }
    }




}
