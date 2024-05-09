using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_matrices_are_identical
{
    [TestMethod]
    public void If_matrix_is_cloned()
    {
        var matrix = new CellMatrix(2, 2);
        matrix[0, 0] = Cell.CreateLiveCell();
        matrix[0, 1] = Cell.CreateDeadCell();
        matrix[1, 0] = Cell.CreateDeadCell();
        matrix[1, 1] = Cell.CreateLiveCell();
        var newMatrix = matrix.Clone();
        Assert.IsTrue(newMatrix[0, 0].IsAlive);
        Assert.IsFalse(newMatrix[0, 1].IsAlive);
        Assert.IsFalse(newMatrix[1, 0].IsAlive);
        Assert.IsTrue(newMatrix[1, 1].IsAlive);
    }
}