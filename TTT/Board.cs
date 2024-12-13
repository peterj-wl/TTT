namespace TTT;

public sealed class Board
{
    private readonly char[] _squares = new char[9];

    public int GetRandomEmptySquare()
    {
        var freeSquares = new List<int>();
        
        var random = new Random();
        return freeSquares[random.Next(freeSquares.Count)];
    }
}
