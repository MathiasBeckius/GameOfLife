using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_cannot_be_accessed
{
    [TestMethod]
    [DataRow(-1, -1)]
    [DataRow(-1, 0)]
    [DataRow(-1, 1)]
    [DataRow(-1, 2)]
    [DataRow(0, -1)]
    [DataRow(0, 2)]
    [DataRow(1, -1)]
    [DataRow(1, 2)]
    [DataRow(2, -1)]
    [DataRow(2, 0)]
    [DataRow(2, 1)]
    [DataRow(2, 2)]
    public void If_attempting_to_count_living_neighbours_for_cell_outside_matrix(int row, int column)
    {
        var matrix = new CellMatrix(2, 2);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => matrix.CountLivingNeighboursForCell(row, column));
    }

    [TestMethod]
    [DataRow(-1, -1)]
    [DataRow(-1, 0)]
    [DataRow(-1, 1)]
    [DataRow(-1, 2)]
    [DataRow(0, -1)]
    [DataRow(0, 2)]
    [DataRow(1, -1)]
    [DataRow(1, 2)]
    [DataRow(2, -1)]
    [DataRow(2, 0)]
    [DataRow(2, 1)]
    [DataRow(2, 2)]
    public void If_attempting_to_read_cell_outside_matrix(int row, int column)
    {
        var matrix = new CellMatrix(2, 2);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => matrix[row, column]);
    }

    [TestMethod]
    [DataRow(-1, -1)]
    [DataRow(-1, 0)]
    [DataRow(-1, 1)]
    [DataRow(-1, 2)]
    [DataRow(0, -1)]
    [DataRow(0, 2)]
    [DataRow(1, -1)]
    [DataRow(1, 2)]
    [DataRow(2, -1)]
    [DataRow(2, 0)]
    [DataRow(2, 1)]
    [DataRow(2, 2)]
    public void If_attempting_to_set_cell_outside_matrix(int row, int column)
    {
        var matrix = new CellMatrix(2, 2);
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => matrix[row, column] = Cell.CreateLiveCell());
    }
}