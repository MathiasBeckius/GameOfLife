using GameOfLife;

var matrix = new CoreLib.CellMatrix(35, 70);

matrix.CreateGlider(10, 15);
matrix.CreateGlider(20, 60);

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
var offsetX = 10;
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

var iteration = 1;
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
    Console.WriteLine($"Iteration #{iteration}");
    Console.ReadLine();
    matrix = CoreLib.PatternGenerator.GenerateNewPattern(matrix);
    iteration++;
}