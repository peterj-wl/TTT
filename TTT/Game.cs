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
        var winningCombinations = new[]
        {
            new[] { 0, 1, 2 },
            new[] { 3, 4, 5 },
            new[] { 6, 7, 8 },
            new[] { 0, 3, 6 },
            new[] { 1, 4, 7 },
            new[] { 2, 5, 8 },
            new[] { 0, 4, 8 },
            new[] { 2, 4, 6 }
        };

        var squares = _board.GetSquares();

        foreach (var combination in winningCombinations)
        {
            if (squares[combination[0]] != '\0' &&
                squares[combination[0]] == squares[combination[1]] &&
                squares[combination[0]] == squares[combination[2]])
            {
                return squares[combination[0]];;
            }
        }

        return '\0';
    }
    
    public void CurrentPlayerMakeMove(int square)
    {
        _currentPlayer.PlaceMarker(_board, square);
    }
    
    public string AutoPlayGame()
    {
        DisplayBoard();
        Console.WriteLine($"Board is created. {_currentPlayer.Name} will start the game.");

        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine($"{_currentPlayer.Name} turn");

            var square = _board.GetRandomEmptySquare();
            CurrentPlayerMakeMove(square);
            
            DisplayBoard();
            
            Thread.Sleep(2000);

            var winner = IsThereAWinner();
            if (winner != '\0')
            {
                Console.WriteLine($"{_currentPlayer.Name} wins!");
                return "winner";
            }
            
            if (IsBoardFull())
            {
                Console.WriteLine("Its a draw!");
                return "draw";
            }

            SwitchPlayer();
        }

        return string.Empty;
    }
    
    public Player GetCurrentPlayer() => _currentPlayer;
    public void SwitchPlayer() => _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
    public bool IsBoardFull() => _board.IsFull();
    private void DisplayBoard() => _board.DisplayBoard();
}