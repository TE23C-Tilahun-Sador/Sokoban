global using Raylib_cs;
using Sokoban;

// Grid
Background bkg = new();








Raylib.InitWindow(900, 700, "The title of my window");
Raylib.SetTargetFPS(60);



Dude player = new(1, 3, bkg);

while (!Raylib.WindowShouldClose())
{

  player.update();

  Raylib.BeginDrawing();


  Raylib.ClearBackground(Color.White);

  for (int x = 0; x < bkg.grid.GetLength(0); x++)
  {
    for (int y = 0; y < bkg.grid.GetLength(1); y++)
    {
      bkg.grid[x, y].Draw(x, y);
    }
  }


  for (int i = 0; i < Tile.tiles.Count; i++)
  {
    Raylib.DrawRectangleRec(Tile.tiles[i].rect, Tile.tiles[i].color);
    Raylib.DrawRectangleLinesEx(Tile.tiles[i].rect, 1, Color.Black);


  }
  Raylib.DrawRectangleRec(player.rect, Color.Black);






  Raylib.EndDrawing();
}