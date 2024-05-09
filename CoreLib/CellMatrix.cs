using System.Data;

namespace CoreLib;

public class CellMatrix
{
    private readonly CircularArray<CircularArray<Cell>> matrix;

    public CellMatrix(uint rowCount, uint columnCount)
    {
        if (rowCount == 0)
            throw new ArgumentOutOfRangeException(nameof(rowCount));
        if (columnCount == 0)
            throw new ArgumentOutOfRangeException(nameof(columnCount));
        matrix = new CircularArray<CircularArray<Cell>>(rowCount);
        foreach (var i in Enumerable.Range(0, matrix.Length))
        {
            matrix[i] = new CircularArray<Cell>(columnCount);
            foreach (var j in Enumerable.Range(0, matrix[i].Length))
                matrix[i][j] = Cell.CreateDeadCell();
        }
    }

    public int RowCount => matrix.Length;

    public int ColumnCount => matrix[0].Length;

    public Cell this[int row, int column]
    {
        get => matrix[ValidateRow(row)][ValidateColumn(column)];
        set => matrix[ValidateRow(row)][ValidateColumn(column)] = value ?? throw new ArgumentNullException(nameof(value));
    }

    public uint CountLivingNeighboursForCell(int row, int column)
    {
        ValidateRow(row);
        ValidateColumn(column);
        uint count = 0;
        foreach (var i in Enumerable.Range(row - 1, 3))
            foreach (var j in Enumerable.Range(column - 1, 3))
            {
                if (i == row && j == column)
                    continue;
                if (matrix[i][j].IsAlive)
                    count++;
            }
        return count;
    }

    private int ValidateRow(int row) =>
        (row >= 0 && row < RowCount) ? row : throw new ArgumentOutOfRangeException(nameof(row));

    private int ValidateColumn(int column) =>
        (column >= 0 && column < ColumnCount) ? column : throw new ArgumentOutOfRangeException(nameof(column));
}