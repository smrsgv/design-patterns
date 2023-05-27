namespace DesignPatterns.Core.Behavioral.Template.BubbleSortAlgorithm;

public abstract class BubbleSorter
{
    private int _operations;
    protected int length = 0;

    protected int DoSort()
    {
        _operations = 0;
        if (length <= 1)
            return _operations;

        for (var nextToLast = length - 2; nextToLast >= 0; nextToLast--) // 3 - 2 - 1 - 0
        for (var index = 0; index <= nextToLast; index++) // 0 - 1 - 2 - 3 | 0 - 1 - 2 | 0 - 1 | 0
        {
            if (OutOfOrder(index))
                Swap(index);
            _operations++;
        }

        return _operations;
    }

    protected abstract void Swap(int index);
    protected abstract bool OutOfOrder(int index);
}