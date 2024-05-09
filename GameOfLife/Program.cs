var matrix = new CoreLib.CellMatrix(20, 20);
matrix[10, 8] = CoreLib.Cell.CreateLiveCell();
matrix[10, 9] = CoreLib.Cell.CreateLiveCell();
matrix[9, 10] = CoreLib.Cell.CreateLiveCell();
matrix[9, 11] = CoreLib.Cell.CreateLiveCell();
matrix[11, 10] = CoreLib.Cell.CreateLiveCell();
matrix[11, 11] = CoreLib.Cell.CreateLiveCell();
matrix[10, 12] = CoreLib.Cell.CreateLiveCell();
matrix[10, 13] = CoreLib.Cell.CreateLiveCell();

while (true)
{
    Console.Clear();
    foreach (var row in Enumerable.Range(0, matrix.RowCount))
    {
        var rowAsString = new System.Text.StringBuilder();
        foreach (var column in Enumerable.Range(0, matrix.ColumnCount))
            rowAsString.Append(matrix[row, column].IsAlive ? "*" : " ");
        Console.WriteLine(rowAsString.ToString());
    }
    Console.ReadLine();
    matrix = CoreLib.PatternGenerator.GenerateNewPattern(matrix);
}