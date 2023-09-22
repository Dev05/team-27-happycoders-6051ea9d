Feature: Move
    I want to move my character. If they attempt to move past a boundary, the move results in no change in position but does increment move count.

@acceptance
Scenario Outline: Move in a direction
    Simple example of how to test move

    Given the character starts at position with XCoordinates <startingPositionX>
    And starts at YCoordinates <startingPositionY>
    And the player chooses to move in <direction>
    And the current move count is <startingMoveCount>
    When the character moves <startingPositionX> <startingPositionY>
    Then the character is now at position with XCoordinates <endingPositionX>
    And YCoordinates  <endingPositionY>
    And the new move count is <endingMoveCount>
    Examples:

        | startingPositionX | startingPositionY | direction | startingMoveCount | endingPositionX | endingPositionY | endingMoveCount |
        | 0                 | 0                 | NORTH     | 10                | 0               | 1               | 11              |
        | 0 | 0 | SOUTH | 32 | 0 | 0 | 33 |
        | 5 | 5 | NORTH | 2 | 5 | 6 | 3 |
        | 5 | 5 | SOUTH | 20 | 5 | 4 | 21 |
        | 5 | 5 | EAST | 30 | 6 | 5 | 31 |
        | 5 | 5 | WEST | 107 | 4 | 5 | 108 |
        | 9 | 9 | NORTH | 2 | 9 | 9 | 3 |
        | 9 | 9 | SOUTH | 20 | 9 | 8 | 21 |
        | 9 | 9 | EAST | 30 | 9 | 9 | 31 |
        | 9 | 9 | WEST | 107 | 8 | 9 | 108 |
        | 0 | 0 | NORTH | 2 | 0 | 1 | 3 |
        | 0 | 0 | SOUTH | 20 | 0 | 0 | 21 |
        | 0 | 0 | EAST | 30 | 1 | 0 | 31 |
        | 0 | 0 | WEST | 107 | 0 | 0 | 108 |
        | 0 | 9 | NORTH | 2 | 0 | 9 | 3 |
        | 0 | 9 | SOUTH | 20 | 0 | 8 | 21 |
        | 0 | 9 | EAST | 30 | 1 | 9 | 31 |
        | 0 | 9 | WEST | 107 | 0 | 9 | 108 |
        | 9 | 0 | NORTH | 2 | 9 | 1 | 3 |
        | 9 | 0 | SOUTH | 20 | 9 | 0 | 21 |
        | 9 | 0 | EAST | 30 | 9 | 0 | 31 |
        | 9 | 0 | WEST | 107 | 8 | 0 | 108 |