using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Cell_is_alive
{
    [TestMethod]
    public void If_live_cell_has_been_created() =>
        Assert.IsTrue(Cell.CreateLiveCell().IsAlive);

    [TestMethod]
    public void If_live_cell_has_2_living_neighbours() =>
        Assert.IsTrue(Cell.CreateLiveCell().Transform(2).IsAlive);

    [TestMethod]
    public void If_live_cell_has_3_living_neighbours() =>
        Assert.IsTrue(Cell.CreateLiveCell().Transform(3).IsAlive);

    [TestMethod]
    public void If_dead_cell_has_3_living_neighbours() =>
        Assert.IsTrue(Cell.CreateDeadCell().Transform(3).IsAlive);
}