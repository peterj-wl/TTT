using System.ComponentModel.DataAnnotations;

namespace TTT;

public sealed class Player
{
    [Required] public readonly string Name;
    [Required] private readonly char _marker;
    public Player(string name, char marker)
    {
        Name = name;
        _marker = marker;
    }
    public void PlaceMarker(Board board, int square)
    {
        var squares = board.GetSquares();
        squares[square] = _marker;
    }
}