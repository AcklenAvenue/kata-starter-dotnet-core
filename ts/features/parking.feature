Feature: Parking Lot Charges for Parking

  We have a new "smart lot" parking lot. Vehicles can enter with a credit card and are charged based on how many spaces
  they take up and how long they stay. Our parking lot can host many types of vehicles and promotes environmental 
  responsibility by giving discounts to vehicles that are easier on the environment. Even though we have a limited 
  number of spaces today, we hope to expand someday. Also, we hope to start with simple vehicles and start generating 
  revenue before adding more complicated vehicle types.

  @wip
  Scenario: Normal Car, Plenty of Space, $5
    Given a parking lot with 50 spaces
    And a normal car
    When the vehicle stays for 1 day
    Then the driver is charged $5
    And the lot is left with 49 spaces

  @wip
  Scenario: Normal Car, 2 Days
    Given a parking lot with 50 spaces
    And a normal car
    When the vehicle stays for 2 days
    Then the driver is charged $10
    And the lot is left with 49 spaces

  @wip
  Scenario: Normal Car, No Space
    Given a parking lot with 0 spaces
    And a normal car
    When the vehicle attempts to enters the lot
    Then the driver is charged $0
    And the car is rejected

  @wip
  Scenario: Electric Car, Plenty of Space, 50% discount
    Given a parking lot with 50 spaces
    And an electric car
    When the vehicle stays for 1 day
    Then the driver is charged $2.50
    And the lot is left with 49 spaces

  @wip
  Scenario: Motorcycle, Plenty of Space, 1/2 space
    Given a parking lot with 50 spaces
    And a motorcycle
    When the vehicle stays for 1 day
    Then the driver is charged $3.00
    And the lot is left with 49.5 spaces

  @wip
  Scenario: Normal Car, Trump Sticker, Charge Double
    Given a parking lot with 50 spaces
    And a normal car
    And the car has a trump sticker
    When the vehicle stays for 1 day
    Then the driver is charged $10
    And the lot is left with 49 spaces

  @wip
  Scenario: Bus, Plenty of Space, 2 Spaces, $9
    Given a parking lot with 50 spaces
    And a bus
    When the vehicle stays for 1 day
    Then the driver is charged $9.00
    And the lot is left with 48 spaces

  @wip
  Scenario: Electric Bus, Plenty of Space, 50% discount
    Given a parking lot with 50 spaces
    And an electric bus
    When the vehicle stays for 1 day
    Then the driver is charged $4.50
    And the lot is left with 48 spaces

  @wip
  Scenario: Helicopter, Plenty of space, 8 Spaces, $35
    Given a parking lot with 50 spaces
    And a helicopter
    When the vehicle stays for 1 day
    Then the driver is charged $35
    And the lot is left with 42 spaces

  @wip
  Scenario: Helicopter, Plenty of space, 2 Days
    Given a parking lot with 50 spaces
    And a helicopter
    When the vehicle stays for 2 days
    Then the driver is charged $70
    And the lot is left with 42 spaces
 
  @wip   
  Scenario: 20% discount for 3 or more days
    Given a parking lot with 50 spaces
    And a bus
    When the vehicle stays for 4 days
    Then the driver is charged $28.80
    And the lot is left with 48 spaces

  @wip
  Scenario: 30% discount for 6 days or more
    Given a parking lot with 50 spaces
    And a normal car
    When the vehicle stays for 8 days
    Then the driver is charged $28
    And the lot is left with 49 spaces
    
  @wip
  Scenario: Electric buses that stay 10 or more days pay $20 flat fee
    Given a parking lot with 50 spaces
    And an electric bus
    When the vehicle stays for 11 days
    Then the driver is charged $20

  @wip
  Scenario: Electric buses that stay a lot more time still pay $20 flat fee
    Given a parking lot with 50 spaces
    And an electric bus
    When the vehicle stays for 15 days
    Then the driver is charged $20