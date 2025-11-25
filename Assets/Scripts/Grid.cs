using System.Data;
using UnityEngine;

public class GameGrid
{
    public Cell[,] cells;
    public int Rows, Columns;
    public float Cellsize;

    public GameGrid(int rows, int columns, float cellsize)
    {
        Rows = rows;
        Columns = columns;
        Cellsize = cellsize;
        cells = new Cell[Rows, Columns];
        Grid_gen();
    }

    private void Grid_gen()
    {
        for (int r = 0; r < Rows; r++)
        {
            for (int c = 0; c < Columns; c++)
                {
                    Vector2 pos = new Vector2(c * Cellsize, r * Cellsize);
                    cells[r, c] = new Cell
                    {
                        Row = r,
                        Column = c,
                        CurrentUnit = null,
                        Position = pos
                    };

                }
        }
    }

    public Cell GetCell(Vector2 pos)
    {
        int c = Mathf.FloorToInt(pos.x / Cellsize);
        int r = Mathf.FloorToInt(pos.y / Cellsize);
        if (r < 0 || r >= Rows || c < 0 || c >= Columns)
        {
            return null;
        }
        return cells[r, c];
    }
}
