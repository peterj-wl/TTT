using TTT;

namespace Test;

public class Tests
{
    [Fact]
    public void GetRandomEmptySquare_BoardHaveSlots_ShouldReturnEmptySquare()
    {
        // Arrange
        var board = new Board();

        // Act
        var availablePosition = board.GetRandomEmptySquare();

        // Assert
        Assert.InRange(availablePosition, 0, 8);
    }
}
