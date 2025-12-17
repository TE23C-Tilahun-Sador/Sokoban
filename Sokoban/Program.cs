global using Raylib_cs;
using Sokoban;

// Grid
Background bkg = new();

bkg.BkgGrid();






Raylib.InitWindow(900, 700, "The title of my window");
Raylib.SetTargetFPS(60);

Dude player = new(1, 3);
while (!Raylib.WindowShouldClose())
{

  player.update();

  Raylib.BeginDrawing();


  Raylib.ClearBackground(Color.White);

  for (int i = 0; i < Tile.tiles.Count; i++)
  {
    Raylib.DrawRectangleRec(Tile.tiles[i].rect, Color.Green);
    Raylib.DrawRectangleLinesEx(Tile.tiles[i].rect, 1, Color.Black);


  }
  Raylib.DrawRectangleRec(player.rect, Color.Black);




  Raylib.EndDrawing();
}