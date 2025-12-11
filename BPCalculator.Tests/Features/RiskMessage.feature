Feature: RiskMessageFeature
  Validates that the correct risk advisory message is shown based on the BP category.

  Scenario: High blood pressure shows correct risk message
    Given the risk systolic value is 150
    And the risk diastolic value is 95
    When I compute the blood pressure category
    Then the risk message should be "Your blood pressure is high. Please consult a healthcare professional."
