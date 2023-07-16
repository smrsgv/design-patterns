using DesignPatterns.Behavioral.Template.BubbleSortAlgorithm;

namespace DesignPatterns.Tests.Behavioral.Template;

public class BubbleSorterTests
{
    [Fact]
    public void IntBubbleSorter_Sort_ReturnsNumberOfOperations()
    {
        // Arrange
        var sorter = new IntBubbleSorter();
        var array = new[] { 4, 2, 5, 1, 3 };

        // Act
        var result = sorter.Sort(array);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void DoubleBubbleSorter_Sort_ReturnsNumberOfOperations()
    {
        // Arrange
        var sorter = new DoubleBubbleSorter();
        var array = new[] { 4.0, 2.0, 5.0, 1.0, 3.0 };

        // Act
        var result = sorter.Sort(array);

        // Assert
        Assert.Equal(10, result);
    }
}