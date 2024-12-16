namespace TTT;

public sealed class Board
{
    private readonly char[] _squares = new char[9];

    public int GetRandomEmptySquare()
    {
        var freeSquares = GetAvailableSquares();
        
        var random = new Random();
        return freeSquares[random.Next(freeSquares.Count)];
    }
    
    public void DisplayBoard()
    {
        Console.WriteLine("Current Board:");
        Console.WriteLine("|---|---|---|");
        for (var i = 0; i < 3; i++)
        {
            Console.Write("|");
            for (var j = 0; j < 3; j++)
            {
                var cell = _squares[i * 3 + j] == '\0' ? ' ' : _squares[i * 3 + j];
                Console.Write($" {cell} |");
            }
            Console.WriteLine();
            Console.WriteLine("|---|---|---|");
        }
    }
    
    private List<int> GetAvailableSquares()
    {
        var availableSquares = new List<int>();

        foreach (var cell in _squares.Select((value, index) => new { value, index }))
        {
            if (cell.value == '\0')
                availableSquares.Add(cell.index);
        }

        return availableSquares;
    }
    
    public char[] GetSquares() => _squares;
    public bool IsFull() => _squares.All(square => square != '\0');
}
