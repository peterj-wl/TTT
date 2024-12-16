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
}