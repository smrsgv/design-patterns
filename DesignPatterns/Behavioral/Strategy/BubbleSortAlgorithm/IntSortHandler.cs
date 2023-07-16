namespace DesignPatterns.Behavioral.Strategy.BubbleSortAlgorithm;

public class IntSortHandler : ISortHandler
{
    private readonly int[] _array;

    public IntSortHandler(int[] array)
    {
        _array = array;
    }

    public int Length => _array.Length;

    public void Swap(int index)
    {
        (_array[index], _array[index + 1]) = (_array[index + 1], _array[index]);
    }

    public bool OutOfOrder(int index)
    {
        return _array[index] > _array[index + 1];
    }

    public int[] GetSortedArray()
    {
        return _array;
    }
}