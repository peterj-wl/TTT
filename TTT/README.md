# README

* ⚠️ **WIP**
* ✅ **GREEN**
* 🧠 **In Discovery**
* ❌ **RED**
* 📝 **TBD**

Two bots playing TicTacToe against each other.

Rules:
A game consist of a board which is 3x3 board
A game consist of two players
Bot 1 always starts the game by placing a marker 'X'
Bot 2 is second and placing a marker 'O'
A game consist of nine moves (max)
After each marker is placed by current player, a switch is done to next player and the game continue until
After a round a check is made if there is a winner -> see scenario (winner)
After a round if there is no winner check if it is a draw -> see scenario (draw)
A game should always generate a winner, or it is a draw
The game is adapting autoplay which means that the bots randomly should take a free spot on the board and place their marker
-> see scenario (free spot on board)

-----------------------------------------------------------------------------------------------------------------------

Scenarios:

Winner -> A winner is a player who wins by three in a row horizontally, vertical or diagonal
Example
{ X, X, X }
{ X, O, O }
{  ,  , O }

All winning scenarios is following:
{ 0, 1, 2 }
{ 3, 4, 5 }
{ 6, 7, 8 }
{ 0, 3, 6 }
{ 1, 4, 7 }
{ 2, 5, 8 }
{ 0, 4, 8 }
{ 2, 4, 6 }

-----------------------------------------------------------------------------------------------------------------------

Draw -> A draw is when none of the player can place three on row horizontally, vertical or diagonal. Which means that
the boards is full
Example
{ X, O, X }
{ X, X, O }
{ O, X, O }

-----------------------------------------------------------------------------------------------------------------------

Free spot on board > A player in making next placement on board by checking which spots that are free and then randomly take one.
Example: {0,1,2,5,6,8} is free -> output random position {8} -> current player places marker on position {8} on the board
