# NumberGame
The implimentation of a simpel number game and the try to bild an algorithmical sover for the game.

The game kommes from a litel game we plaid on Paper at UNI.
Ther the game is playde as folowed:
The game bord is the following:       Therfor it kan program internaly depicet as a vecor of the form:
  ||||                                4
 ||||||                               6
||||||||                              8
To players play against eche other. in each turn the a player can kros x '|' in a row. This can be dipikted in the computer by diminishing the game vector by a vector wich only has wone komponent.
A player looses if he has to cros the last '|' the other player therfor has wonne in thise case.
Therfor the goal of each palyer is to perform coroses in a way wich forses the other player in to beeing the Person how has to cros the last '|'.
A sampel game therfor can be like the folowing:
4   P1: 1   P2: 1   P1: 1   P2: 1   P1: 1   P2: 1   P1: 1
6  ->   6   ->  4   ->  4   ->  3   ->  1   ->  1   ->  0 -> Player 1 has wone since P2 moust cors the last point in row 1.
8       8       8       1       1       1       0       0

The goal of the program is to simulate the game an have to playmodes:
1 v 1 with too person wich play the game on the computer
1 v algorithem were an algorithem moust be bult to play the game.

To write the algorithem ther moust be writen a system wich can detect wenn the outcom of a game should be disisif.
Therfor the computer sould save al the mouves a player ever dose so that the programers can understand the posibel solutions.
