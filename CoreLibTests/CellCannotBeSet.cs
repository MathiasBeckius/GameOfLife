using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_cannot_be_set
{
    [TestMethod]
    public void If_attempting_to_cell_to_null()
    {
        var matrix = new CellMatrix(1, 1);
        Assert.ThrowsException<ArgumentNullException>(() => matrix[0, 0] = null);
    }
}