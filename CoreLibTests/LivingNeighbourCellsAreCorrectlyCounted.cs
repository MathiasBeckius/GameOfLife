using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Living_neighbour_cells_are_correctly_counted
{
    [TestMethod]
    public void If_there_are_no_living_neighbours()
    {
        var matrix = new CellMatrix(3, 3);
        Assert.AreEqual<uint>(0, matrix.CountLivingNeighboursForCell(1, 1));
    }

    [TestMethod]
    public void If_all_but_one_neighbour_are_alive()
    {
        var matrix = new CellMatrix(3, 3);
        foreach (var i in Enumerable.Range(0, matrix.RowCount))
            foreach (var j in Enumerable.Range(0, matrix.ColumnCount))
                matrix[i, j] = Cell.CreateLiveCell();        
        matrix[2, 2] = Cell.CreateDeadCell();
        Assert.AreEqual<uint>(7, matrix.CountLivingNeighboursForCell(1, 1));
    }

    [TestMethod]
    public void If_all_neighbours_are_alive_and_cell_is_in_the_middle()
    {
        var matrix = new CellMatrix(3, 3);
        foreach (var i in Enumerable.Range(0, matrix.RowCount))
            foreach (var j in Enumerable.Range(0, matrix.ColumnCount))
                matrix[i, j] = Cell.CreateLiveCell();
        Assert.AreEqual<uint>(8, matrix.CountLivingNeighboursForCell(1, 1));
    }

    [TestMethod]
    public void If_all_neighbours_are_alive_and_cell_is_in_upper_left_corner()
    {
        var matrix = new CellMatrix(3, 3);
        foreach (var i in Enumerable.Range(0, matrix.RowCount))
            foreach (var j in Enumerable.Range(0, matrix.ColumnCount))
                matrix[i, j] = Cell.CreateLiveCell();
        Assert.AreEqual<uint>(8, matrix.CountLivingNeighboursForCell(0, 0));
    }

    [TestMethod]
    public void If_neighbours_at_negative_coordinates_are_dead_and_cell_is_in_upper_left_corner()
    {
        var matrix = new CellMatrix(3, 3);
        matrix[0, 1] = Cell.CreateLiveCell();
        matrix[1, 0] = Cell.CreateLiveCell();
        matrix[1, 1] = Cell.CreateLiveCell();
        Assert.AreEqual<uint>(3, matrix.CountLivingNeighboursForCell(0, 0));
    }

    [TestMethod]
    public void If_neighbours_at_negative_coordinates_are_dead_and_cell_is_in_bottom_left_corner()
    {
        var matrix = new CellMatrix(3, 3);
        matrix[1, 0] = Cell.CreateLiveCell();
        matrix[1, 1] = Cell.CreateLiveCell();
        matrix[2, 1] = Cell.CreateLiveCell();
        Assert.AreEqual<uint>(3, matrix.CountLivingNeighboursForCell(0, 0));
    }

    [TestMethod]
    public void If_neighbours_at_negative_coordinates_are_dead_and_cell_is_in_upper_right_corner()
    {
        var matrix = new CellMatrix(3, 3);
        matrix[0, 1] = Cell.CreateLiveCell();
        matrix[1, 1] = Cell.CreateLiveCell();
        matrix[1, 2] = Cell.CreateLiveCell();
        Assert.AreEqual<uint>(3, matrix.CountLivingNeighboursForCell(0, 0));
    }

    [TestMethod]
    public void If_neighbours_at_negative_coordinates_are_dead_and_cell_is_in_bottom_right_corner()
    {
        var matrix = new CellMatrix(3, 3);
        matrix[1, 1] = Cell.CreateLiveCell();
        matrix[1, 2] = Cell.CreateLiveCell();
        matrix[2, 1] = Cell.CreateLiveCell();
        Assert.AreEqual<uint>(3, matrix.CountLivingNeighboursForCell(0, 0));
    }
}