using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_matrix_does_not_contain_any_null_references
{
    [TestMethod]
    public void If_it_has_been_instantiated()
    {
        var matrix = new CellMatrix(2, 2);
        Assert.IsNotNull(matrix[0, 0]);
        Assert.IsNotNull(matrix[0, 1]);
        Assert.IsNotNull(matrix[1, 0]);
        Assert.IsNotNull(matrix[1, 1]);
    }
}