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
    
    [Fact]
    public void PlaceMarker_Bot1PlaysMarkerOnSquarePositionOne_ShouldPlaceMarkerOnSquareOneOnBoard()
    {
        // Arrange
        var player = new Player("Bot1", 'X');
        var board = new Board();
        var expectedBoard = new char[] { '\0', 'X', '\0', '\0', '\0', '\0', '\0', '\0', '\0' };

        // Act
        player.PlaceMarker(board, 1);

        // Assert
        Assert.Equal(expectedBoard, board.GetSquares());
    }
}
