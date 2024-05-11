namespace GameOfLife;

public static class Patterns
{
    public static void CreateGlider(this CoreLib.CellMatrix matrix, int offsetY, int offsetX)
    {
        matrix[offsetY, 1 + offsetX] = CoreLib.Cell.CreateLiveCell();
        matrix[offsetY + 1, 2 + offsetX] = CoreLib.Cell.CreateLiveCell();
        matrix[offsetY + 2, 0 + offsetX] = CoreLib.Cell.CreateLiveCell();
        matrix[offsetY + 2, 1 + offsetX] = CoreLib.Cell.CreateLiveCell();
        matrix[offsetY + 2, 2 + offsetX] = CoreLib.Cell.CreateLiveCell();
    }
}