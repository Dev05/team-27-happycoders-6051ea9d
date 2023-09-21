Feature: Position
    This is to validate number of parameter passed to position calls.

@acceptance
Scenario Outline: Initialize.
    Simple example of how to test number of parameters to position class.

    Given the Position parameters <X>
    And the  <Y>
    When Position constructor  is called
    Then validate the position parameter are assigned
 

    Examples:

        | X | Y | x | y |
        | 0 | 9 | 0 | 9 |
        | 9 | 9 | 9 | 9 |
        | 9 | 0 | 9 | 0 |