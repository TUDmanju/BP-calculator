Feature: Blood Pressure Category

  Scenario: Ideal Blood Pressure
    Given the systolic value is 110
    And the diastolic value is 70
    When I calculate the blood pressure category
    Then the result should be "Ideal Blood Pressure"

  Scenario: Low Blood Pressure
    Given the systolic value is 85
    And the diastolic value is 55
    When I calculate the blood pressure category
    Then the result should be "Low Blood Pressure"

  Scenario: High Blood Pressure
    Given the systolic value is 150
    And the diastolic value is 95
    When I calculate the blood pressure category
    Then the result should be "High Blood Pressure"
