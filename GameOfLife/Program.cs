var matrix = new CoreLib.CellMatrix(35, 70);
var offsetX = 15;
matrix[0, 1 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[1, 2 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[2, 0 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[2, 1 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[2, 2 + offsetX] = CoreLib.Cell.CreateLiveCell();
var offsetY = 3;
matrix[offsetY + 10, 8] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 10, 9] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 9, 10] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 9, 11] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 11, 10] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 11, 11] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 10, 12] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 10, 13] = CoreLib.Cell.CreateLiveCell();
offsetY = 10;
offsetX = 10;
matrix[offsetY + 15, 0 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 15, 1 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 15, 2 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 16, 3 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 17, 3 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 17, 4 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 17, 5 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 18, 3 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 19, 0 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 19, 1 + offsetX] = CoreLib.Cell.CreateLiveCell();
matrix[offsetY + 19, 2 + offsetX] = CoreLib.Cell.CreateLiveCell();

while (true)
{
    Console.Clear();
    foreach (var row in Enumerable.Range(0, matrix.RowCount))
    {
        var rowAsString = new System.Text.StringBuilder();
        foreach (var column in Enumerable.Range(0, matrix.ColumnCount))
            rowAsString.Append(matrix[row, column].IsAlive ? '*' : ' ');
        rowAsString.Append('|');
        Console.WriteLine(rowAsString.ToString());
    }
    var lineRow = new System.Text.StringBuilder();
    foreach (var column in Enumerable.Range(0, matrix.ColumnCount))
        lineRow.Append('-');
    Console.WriteLine(lineRow.ToString());
    Console.ReadLine();
    matrix = CoreLib.PatternGenerator.GenerateNewPattern(matrix);
}