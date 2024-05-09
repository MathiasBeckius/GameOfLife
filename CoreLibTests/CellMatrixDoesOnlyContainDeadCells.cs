using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_matrix_does_only_contain_dead_cells
{
    [TestMethod]
    public void If_it_has_been_instantiated()
    {
        var matrix = new CellMatrix(2, 2);
        Assert.IsFalse(matrix[0, 0].IsAlive);
        Assert.IsFalse(matrix[0, 1].IsAlive);
        Assert.IsFalse(matrix[1, 0].IsAlive);
        Assert.IsFalse(matrix[1, 1].IsAlive);
    }
}