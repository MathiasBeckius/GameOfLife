namespace CoreLib;

public class Cell
{
    public static Cell CreateDeadCell() => new() { IsAlive = false };

    public static Cell CreateLiveCell() => new() { IsAlive = true };

    public Cell Transform(uint livingNeighbours)
    {
        if (livingNeighbours > 8)
            throw new ArgumentOutOfRangeException(nameof(livingNeighbours));
        if (!IsAlive && livingNeighbours == 3)
            return CreateLiveCell();
        if (IsAlive && (livingNeighbours < 2 || livingNeighbours > 3))
            return CreateDeadCell();
        return this;
    }

    public bool IsAlive { get; private set; }

    private Cell() {}
}