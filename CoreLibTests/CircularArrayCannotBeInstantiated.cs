using CoreLib;

namespace CoreLibTests;

[TestClass]
public class Circular_array_cannot_be_instantiated
{
    [TestMethod]
    public void If_size_is_zero() =>
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new CircularArray<int>(0));
}