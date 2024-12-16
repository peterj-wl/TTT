namespace TTT;

public sealed class Game
{
    private readonly Board _board;

    private readonly Player _player1;
    private readonly Player _player2;

    private Player _currentPlayer;

    public Game()
    {
        _board = new Board();

        _player1 = new Player("Bot 1", 'X');
        _player2 = new Player("Bot 2", 'O');

        _currentPlayer = _player1;
    }
    
    public char IsThereAWinner()
    {
        var squares = _board.GetSquares();

        foreach (var combination in squares)
        {
            if (squares[0] == 'X' &&
                squares[1] == 'X' &&
                squares[2] == 'X')
            {
                return 'X';
            }
        }

        return '\0';
    }
    
    public void CurrentPlayerMakeMove(int square)
    {
        _currentPlayer.PlaceMarker(_board, square);
    }
    
    public Player GetCurrentPlayer() => _currentPlayer;
    public void SwitchPlayer() => _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
}