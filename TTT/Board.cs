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
}
