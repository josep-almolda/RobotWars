# RobotWars

## How to run
open the solution on VS2017 and click F5

once in the console enter each line separately and end with a line with a single `F` (fight)
the output will be printed in the console

## Assumptions
there are a number of assumptions made for this exercise:
- In a fight there can be any number of robots in the arena
- All robots deploy and move in one go, one after the other
- If a robot tries to leave the arena the movement does nothing
- If a robot tries to move where another robot is standing the movement does nothing

## Notes
- I added a new input line in the console `F` to signal the end of the input and start of the fight, that was necessary because the arena accepts any number of robts
- The Processor acts on an input, so instead of the console the orders could be sent in a different way with minimum change
- If the input is not right the program will fail and return a message why it didn't work. At the moment the input has to follow the format strictly
