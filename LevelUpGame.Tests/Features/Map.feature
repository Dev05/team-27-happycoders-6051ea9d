Feature: Map
    I want to initialize Map and validate position.

@acceptance
Scenario Outline: Initialize Map and Validate
    Simple example of how to test Initialize and Validate based on defined Size

    Given the Map size with <Minx>
    And the defined <MinY>
    And the defined <MaxX>
    And the defined <MaxY>
    When the current position with XCoordinate <currentPositionX>
    And the current position with YCoordinate <currentPositionY>
    Then validate the position is defined with in the Map Size <IsValidCoordinate>
 

    Examples:

        | Minx | MinY | MaxX | MaxY | currentPositionX | currentPositionY | IsValidCoordinate |
        |  0   |  0   |  9   |  9   |   0          |    10        |     false |
        |  0   |  0   |  9   |  9   |   9          |    9        |     true   |
        |  0   |  0   |  9   |  9   |   -1          |   9        |     false  |
        |  0   |  0   |  9   |  9   |   5          |    5        |     true   |
        