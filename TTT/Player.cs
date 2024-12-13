namespace TTT;

public sealed class Player
{
    private readonly string Name;
    private readonly char _marker;
    public Player() {}
    public void PlaceMarker(Board board, int square)
    {
        var squares = board.GetSquares();
        squares[square] = _marker;
    }
}