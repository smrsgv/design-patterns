using DesignPatterns.Behavioral.Strategy.BubbleSortAlgorithm;

namespace DesignPatterns.Tests.Behavioral.Strategy;

public class BubbleSorterTests
{
    [Fact]
    public void DoSort_IntArray_ReturnsSortedArray()
    {
        // Arrange
        var array = new[] { 1, 5, 2, 4, 3 };
        var expected = new[] { 1, 2, 3, 4, 5 };

        var intSortHandler = new IntSortHandler(array);
        var sorter = new BubbleSorter(intSortHandler);

        // Act
        sorter.DoSort();

        // Assert
        Assert.Equal(expected, intSortHandler.GetSortedArray());
    }

    [Fact]
    public void DoSort_IntArrayContainsDuplicateValues_ReturnsSortedArray()
    {
        // Arrange
        var array = new[] { 1, 5, 2, 3, 3 };
        var expected = new[] { 1, 2, 3, 3, 5 };

        var intSortHandler = new IntSortHandler(array);
        var sorter = new BubbleSorter(intSortHandler);

        // Act
        sorter.DoSort();

        // Assert
        Assert.Equal(expected, intSortHandler.GetSortedArray());
    }

    [Fact]
    public void DoSort_DoubleArray_ReturnsSortedArray()
    {
        // Arrange
        var array = new[] { 1.0, 5, 2, 4, 3.0 };
        var expected = new[] { 1.0, 2, 3.0, 4, 5 };

        var doubleSortHandler = new DoubleSortHandler(array);
        var sorter = new BubbleSorter(doubleSortHandler);

        // Act
        sorter.DoSort();

        // Assert
        Assert.Equal(expected, doubleSortHandler.GetSortedArray());
    }
}