namespace CoreLib;

public static class PatternGenerator
{
    public static CellMatrix GenerateNewPattern(CellMatrix matrix)
    {
        var newMatrix = matrix.Clone();
        foreach (var row in Enumerable.Range(0, matrix.RowCount))
            foreach (var column in Enumerable.Range(0, matrix.ColumnCount))
            {
                var livingNeighbours = matrix.CountLivingNeighboursForCell(row, column);
                newMatrix[row, column] = matrix[row, column].Transform(livingNeighbours);
            }
        return newMatrix;
    }
}