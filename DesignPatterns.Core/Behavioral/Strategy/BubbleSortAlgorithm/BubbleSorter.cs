namespace DesignPatterns.Core.Behavioral.Strategy.BubbleSortAlgorithm;

public class BubbleSorter
{
    private readonly ISortHandler _sortHandler;

    public BubbleSorter(ISortHandler sortHandler)
    {
        _sortHandler = sortHandler;
    }

    public void DoSort()
    {
        var swapCount = 0;

        for (var j = _sortHandler.Length - 1; j >= 0; j--)
        {
            for (var i = 0; i < j; i++)
                if (_sortHandler.OutOfOrder(i))
                {
                    _sortHandler.Swap(i);
                    swapCount++;
                }

            swapCount = 0;
        }
    }
}