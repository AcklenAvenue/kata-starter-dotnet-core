Feature: Flexible Discounts
  
  We have a store that specializes in giving various types of discounts for 
  various reasons. These discounts change often and are applied at the register.

  @wip
  Scenario: Normal price (No discount)
    Given the date is "2019/09/29"
    And the customer's shopping cart has a "jumprope" that costs $10
    When calculating the total
    Then the total should be $10

  @wip
  Scenario: Monday's are 20% off all shirts
    Given the date is "2019/09/30"
    And the customer's shopping cart has a "shirt" that costs $10
    When calculating the total
    Then the discounted total should be $8

  @wip
  Scenario: All pants are $2 off
    Given the customer's shopping cart has a "pair of pants" that costs $7
    When calculating the total
    Then the discounted total should be $5

  @wip
  Scenario: Women get 10% off everything
    Given the customer is a woman
    And the customer's shopping cart has a "hair dryer" that costs $10
    When calculating the total
    Then the discounted total should be $9

  @wip
  Scenario: Only one discount applied to an item, Higher price wins
    Given the customer is a woman
    And the date is "2019/9/30"
    And the customer's shopping cart has a "shirt" that costs $10
    When calculating the total
    Then the discounted total should be $9
    