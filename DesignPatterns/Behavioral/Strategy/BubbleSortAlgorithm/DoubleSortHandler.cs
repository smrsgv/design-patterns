namespace DesignPatterns.Behavioral.Strategy.BubbleSortAlgorithm;

public class DoubleSortHandler : ISortHandler
{
    private readonly double[] _array;

    public DoubleSortHandler(double[] array)
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

    public double[] GetSortedArray()
    {
        return _array;
    }
}