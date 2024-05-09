using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_matrix_cannot_be_instantiated
{
    [TestMethod]
    [DataRow((uint)0, (uint)0)]
    [DataRow((uint)0, (uint)1)]
    [DataRow((uint)1, (uint)0)]
    public void If_row_count_or_columnt_count_is_zero(uint rowCount, uint columnCount) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CellMatrix(rowCount, columnCount));
}