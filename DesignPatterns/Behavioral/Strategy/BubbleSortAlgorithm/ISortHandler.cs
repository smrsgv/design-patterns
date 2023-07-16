namespace DesignPatterns.Behavioral.Strategy.BubbleSortAlgorithm;

public interface ISortHandler
{
    int Length { get; }
    void Swap(int index);
    bool OutOfOrder(int index);
}