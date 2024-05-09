using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_is_dead
{
    [TestMethod]
    public void If_dead_cell_has_been_created() =>
        Assert.IsFalse(Cell.CreateDeadCell().IsAlive);

    [TestMethod]
    [DataRow((uint)0)]
    [DataRow((uint)1)]
    [DataRow((uint)2)]
    public void If_dead_cell_has_less_than_3_living_neighbours(uint livingNeighbours) =>
        Assert.IsFalse(Cell.CreateDeadCell().Transform(livingNeighbours).IsAlive);

    [TestMethod]
    [DataRow((uint)4)]
    [DataRow((uint)5)]
    [DataRow((uint)6)]
    [DataRow((uint)7)]
    [DataRow((uint)8)]
    public void If_dead_cell_has_more_than_3_living_neighbours(uint livingNeighbours) =>
        Assert.IsFalse(Cell.CreateDeadCell().Transform(livingNeighbours).IsAlive);

    [TestMethod]
    public void If_live_cell_has_no_living_neighbours() =>
        Assert.IsFalse(Cell.CreateLiveCell().Transform(0).IsAlive);

    [TestMethod]
    [DataRow((uint)0)]
    [DataRow((uint)1)]
    public void If_live_cell_has_less_than_2_living_neighbours(uint livingNeighbours) =>
        Assert.IsFalse(Cell.CreateLiveCell().Transform(livingNeighbours).IsAlive);

    [TestMethod]
    [DataRow((uint)4)]
    [DataRow((uint)5)]
    [DataRow((uint)6)]
    [DataRow((uint)7)]
    [DataRow((uint)8)]
    public void If_live_cell_has_more_than_3_living_neighbours(uint livingNeighbours) =>
        Assert.IsFalse(Cell.CreateLiveCell().Transform(livingNeighbours).IsAlive);
}