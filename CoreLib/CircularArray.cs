using System.Collections;

namespace CoreLib;

public class CircularArray<T>
{
    private readonly T[] array;

    public CircularArray(uint size)
    {
        if (size == 0)
            throw new ArgumentOutOfRangeException(nameof(size));
        array = new T[size];
    }

    public int Length => array.Length;

    public T this[int i]
    {
        get => array[Index(i)];
        set => array[i] = value;
    }

    private int Index(int i) => i < 0 ? Length + i : i % Length;
}
