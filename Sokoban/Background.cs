
using Sokoban;

public class Background
{
    // Detta är själva rutnätet som är för rutor som inte har någon rörelse som väggar och golv
    public Tile[,] grid = new Tile[11, 9];


    // Detta är själva rutnätet som är för rutor som har rörelse som spelaren och lådor
    public Tile[,] BoxGrid;

    // Detta är en konstruktor för bakgrunden, alltså körs det vid en ny instans av en bakgrund.
    public Background()
    {
        BoxGrid = new Tile[grid.GetLength(0), grid.GetLength(1)];
        if (grid.GetLength(0) >= grid.GetLength(1))
        {
            Tile.size = Raylib.GetScreenWidth() / grid.GetLength(0);
        }

        else if (grid.GetLength(0) <= grid.GetLength(1))
        {
            Tile.size = Raylib.GetScreenHeight() / grid.GetLength(1);
        }



        for (int y = 0; y < grid.GetLength(1); y++)
        {
            // Den inre loopen här körs en gång per unik position i den tvådimensionella arrayen, och variablerna x och y 
            // har index-värdena för den aktuella positionen.
            for (int x = 0; x < grid.GetLength(0); x++)
            {

                grid[x, y] = new Floor(x, y); // Ändrar alla positioners värde till 4.


                
            }
        }

        // Dessa for loopar lägger till en vägg på varje kant på rutnätet 
        for (int y = 0; y < grid.GetLength(1); y++)
        {
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                if (x == 0 || y == 0 || x == grid.GetLength(0) - 1 || y == grid.GetLength(1) - 1)
                {
                    grid[x, y] = new Wall(x, y);
                }


            }
        }
        grid[4, 4] = new FloorWithWin(4, 4);
        grid[4, 7] = new FloorWithWin(4, 7);

        for (int y = 0; y < BoxGrid.GetLength(1); y++)
        {
            for (int x = 0; x < BoxGrid.GetLength(0); x++)
            {
                BoxGrid[x, y] = new Tile(x, y);
            }
        }

        BoxGrid[4, 3] = new Box(4, 3);
        BoxGrid[4, 5] = new Box(4, 5);
        






    }

    public bool HasWon()
    {
        for (int y = 0; y < grid.GetLength(0); y++)
        {
            for (int x = 0; x < grid.GetLength(1); x++)
            {
                if (grid[y, x] is FloorWithWin && BoxGrid[y, x] is not Box)
                {
                    return false;
                }

            }

        }

        return true;
    }






}
