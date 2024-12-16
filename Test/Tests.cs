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
    
    [Fact]
    public void SwitchingPlayers_SwitchPlayerFromCurrentToNextPlayer_ShouldReturnNextPlayerWhichIsBot2()
    {
        // Arrange
        var game = new Game();
        var playerBeforeSwitch = game.GetCurrentPlayer().Name;

        // Act
        game.SwitchPlayer();
        var playerAfterSwitch = game.GetCurrentPlayer().Name;

        // Assert
        Assert.Equal("Bot 1", playerBeforeSwitch);
        Assert.Equal("Bot 2", playerAfterSwitch);
    }
    
    [Theory]
    [InlineData(0,1,2)]
    [InlineData(0,3,6)]
    [InlineData(0,4,8)]
    public void IsThereAWinner_XPlaces3Markers_ShouldReturnXAsWinner(int square1, int square2, int square3)
    {
        // Arrange
        var game = new Game();
        
        game.CurrentPlayerMakeMove(square1);
        game.CurrentPlayerMakeMove(square2);
        game.CurrentPlayerMakeMove(square3);

        // Act
        var winner = game.IsThereAWinner();

        // Assert
        Assert.Equal('X', winner);
    }
    
    [Theory]
    [InlineData(0,1,2)]
    [InlineData(0,3,6)]
    [InlineData(0,4,8)]
    public void IsThereAWinner_OPlaces3Markers_ShouldReturnOAsWinner(int square1, int square2, int square3)
    {
        // Arrange
        var game = new Game();
        
        game.SwitchPlayer();
        game.CurrentPlayerMakeMove(square1);
        game.CurrentPlayerMakeMove(square2);
        game.CurrentPlayerMakeMove(square3);

        // Act
        var winner = game.IsThereAWinner();

        // Assert
        Assert.Equal('O', winner);
    }
    
    [Theory]
    [InlineData(0,2,4)]
    public void IsThereAWinner_NoWinner_ShouldReturnNoWinner(int square1, int square2, int square3)
    {
        // Arrange
        var game = new Game();
        
        game.SwitchPlayer();
        game.CurrentPlayerMakeMove(square1);
        game.CurrentPlayerMakeMove(square2);
        game.CurrentPlayerMakeMove(square3);

        // Act
        var winner = game.IsThereAWinner();

        // Assert
        Assert.Equal('\0', winner);
    }
}
