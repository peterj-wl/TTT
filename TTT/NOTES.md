Overall strategy:
Using technique "outside to inside" which means that individual concepts is developed in isolation before it get inside
the "autoplay" function.
Example of outside functions is methods outside the game itself e.g.
-Find an empty square on board
-Player make a move on the board (place marker)

Then going more and more to the inner parts which consist of e.g.
-Check winner
-Switch players

Then for final make the inside work which is more or less the autoplay

### Goal: Init the game by creating the readme + notes for the game. Also start defining the Board with the find empty random square
### Time 🍅
### Notes:
-Find an empty random square
input = none
output = a random square that is free in the board (e.g square 8). If the board does not have any spots then return -1 (to avoid using exceptions)


### Goal: Create the Player with the place marker
### Time 🍅
### Notes:
-Place marker
input = a square position (e.g. 1)
output = board will now have a marker on square position 1


### Goal: Create the Game according to the rules which is set for the game (readme) also create Check for winner and wrapper for current player place a marker
### Time 🍅
### Notes:
-Get winner
input = none
output = will output either a '\0' (null = no winner) or a winner with either 'X' or 'O'

winning combinations (in readme)



### Goal: Create the autoplay also go through the techdebt and see if there is something to be fixed
### Time 🍅
### Notes:
-Autoplay
input = none
output = will output either "winner" or "draw" and who was the winner (name).
It will write out each round in console which player have made a marker place on a free square until game is over (9 rounds)
