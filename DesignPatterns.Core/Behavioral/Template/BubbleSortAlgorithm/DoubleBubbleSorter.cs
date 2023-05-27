namespace DesignPatterns.Core.Behavioral.Template.BubbleSortAlgorithm;

public class DoubleBubbleSorter : BubbleSorter
{
    private double[] _array;

    public int Sort(double[] theArray)
    {
        _array = theArray;
        length = _array.Length;
        return DoSort();
    }

    protected override void Swap(int index)
    {
        (_array[index], _array[index + 1]) = (_array[index + 1], _array[index]);
    }

    protected override bool OutOfOrder(int index)
    {
        return _array[index] > _array[index + 1];
    }
}