using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_cannot_be_transformed
{
    [TestMethod]
    [DataRow((uint)9)]
    [DataRow((uint)10)]
    [DataRow((uint)11)]
    public void If_cell_is_alive_and_alive_neighbours_are_greater_than_8(uint livingNeighbours) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Cell.CreateLiveCell().Transform(livingNeighbours));

    [TestMethod]
    [DataRow((uint)9)]
    [DataRow((uint)10)]
    [DataRow((uint)11)]
    public void If_cell_is_dead_and_alive_neighbours_are_greater_than_8(uint livingNeighbours) =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => Cell.CreateDeadCell().Transform(livingNeighbours));
}