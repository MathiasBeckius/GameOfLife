using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Circular_array_handles_index_out_of_range
{
    [TestMethod]
    public void If_index_is_negative()
    {
        var array = new CircularArray<int>(3);
        foreach (var i in Enumerable.Range(0, 3))
            array[i] = i;
        Assert.AreEqual(2, array[-1]);
        Assert.AreEqual(1, array[-2]);
        Assert.AreEqual(0, array[-3]);
    }

    [TestMethod]
    public void If_index_is_above_max_index()
    {
        var array = new CircularArray<int>(3);
        foreach (var i in Enumerable.Range(0, 3))
            array[i] = i;
        Assert.AreEqual(0, array[3]);
        Assert.AreEqual(1, array[4]);
        Assert.AreEqual(2, array[5]);
    }
}