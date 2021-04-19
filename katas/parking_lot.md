# Parking Lot Kata

## Story

We have a new "smart lot" parking lot. Our parking lot can host many types of vehicles and promotes environmental responsibility by giving discounts to vehicles that are easier on the environment. Even though we have a limited number of spaces today, we hope to expand someday. Also, we hope to start with simple vehicles and start generating revenue before adding more complicated vehicle types.

## Rules

* Follow SOLID principles
* Ping Pong Pairing
* This is a TDD Kata. Red-Green-Refactor (modified)
* Follow "arabic form" when implementing specs.
* No copy pasting
* No Regex

## Specs

 Scenario: Normal Car, Plenty of Space, $5
 ```
    Given a parking lot with 50 spaces
    And a normal car
    When the vehicle stays for one day 
    Then the driver is charged $5
    And the lot is left with 49 spaces
```
  Scenario: Normal Car, One Space Left
```
    Given a parking lot with 1 spaces
    And a normal car
    When the vehicle stays for one day
    Then the driver is charged $5
    And the lot is left with 0 spaces
```  
  Scenario: Normal Car, No Space
```
    Given a parking lot with 0 spaces
    And a normal car
    When the vehicle attempts to enters the lot
    Then the driver is charged $0
    And the car is rejected
```
   Scenario: Electric Car, Plenty of Space, 50% discount
 ```
    Given a parking lot with 50 spaces
    And an electric car
    When the vehicle stays for one day
    Then the driver is charged $2.50
    And the lot is left with 49 spaces
 ```
  Scenario: Motocycle, Plenty of Space, 1/2 space
 ```
    Given a parking lot with 50 spaces
    And a motorcycle
    When the vehicle stays for one day
    Then the driver is charged $3.00
    And the lot is left with 49.5 spaces
 ```
  Scenario: Normal Car, Trump Sticker, Charge Double
 ```
    Given a parking lot with 50 spaces
    And a normal car
    And the car has a trump sticker
    When the vehicle stays for one day
    Then the driver is charged $10
    And the lot is left with 49 spaces
```
 Scenario: Bus, Plenty of Space, 2 Spaces, $9
```
    Given a parking lot with 50 spaces
    And a bus
    When the vehicle stays for one day
    Then the driver is charged $9.00
    And the lot is left with 48 spaces
```
  Scenario: Electric Bus, Plenty of Space, 50% discount
```
    Given a parking lot with 50 spaces
    And an electric bus
    When the vehicle stays for one day
    Then the driver is charged $4.50
    And the lot is left with 48 spaces
```
  Scenario: Helicopter, Plenty of space, 8 Spaces, $35
```
    Given a parking lot with 50 spaces
    And a helicopter
    When the vehicle stays for one day
    Then the driver is charged $35
    And the lot is left with 42 spaces
```
  Scenario: Helicopter, Plenty of space, 2 Days
```
    Given a parking lot with 50 spaces
    And a helicopter
    When the vehicle stays for two days
    Then the driver is charged $70
    And the lot is left with 42 spaces
```
  Scenario: 20% discount for 3 or more days
```
    Given a parking lot with 50 spaces
    And a bus
    When the vehicle stays for four days
    Then the driver is charged $28.80
    And the lot is left with 48 spaces
```
  Scenario: 30% discount for 6 days or more
```
    Given a parking lot with 50 spaces
    And a normal car
    When the vehicle stays for eight days
    Then the driver is charged $28
    And the lot is left with 49 spaces
```
 
## Techniques/Practices

This is what you should be learning through this kata.

[To Be Determined]

## Inspiration

This kata was inspired by https://github.com/kamranahmedse/design-patterns-for-humans. 
