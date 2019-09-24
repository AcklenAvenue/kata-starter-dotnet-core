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

1. Normal Car, Plenty of Space, $5
  * Given a parking lot with 50 spaces 
  * and a normal car
  * when the vehicle stays for one day
  * then the driver is charged $5 
  * and the lot is left with 49 spaces
2. Normal Car, One Space Left
  * Given a parking lot with 1 spaces 
  * and a normal car
  * when the vehicle stays for one day
  * then the driver is charged $5 
  * and the lot is left with 0 spaces
3. Normal Car, No Space
  * Given a parking lot with 0 spaces 
  * and a normal car
  * when the vehicle attempts to enters the lot
  * then the driver is charged $0
  * and the car is rejected
4. Electric Car, Plenty of Space, 50% discount
  * Given a parking lot with 50 spaces 
  * and an electric car
  * when the vehicle stays for one day
  * then the driver is charged $2.50 
  * and the lot is left with 49 spaces
5. Motocycle, Plenty of Space, 1/2 space
  * Given a parking lot with 50 spaces 
  * and a motorcycle
  * when the vehicle stays for one day
  * then the driver is charged $3.00
  * and the lot is left with 49.5 spaces
6. Normal Car, Trump Sticker, Charge Double
  * Given a parking lot with 50 spaces 
  * and a normal car
  * and the car has a trump sticker
  * when the vehicle stays for one day
  * then the driver is charged $10 
  * and the lot is left with 49 spaces
7. Bus, Plenty of Space, 2 Spaces, $9
  * Given a parking lot with 50 spaces 
  * and a bus
  * when the vehicle stays for one day
  * then the driver is charged $9.00
  * and the lot is left with 48 spaces
8. Electric Bus, Plenty of Space, 50% discount
  * Given a parking lot with 50 spaces 
  * and an electric bus
  * when the vehicle stays for one day
  * then the driver is charged $4.50
  * and the lot is left with 48 spaces
9. Helicopter, Plenty of space, 8 Spaces, $35
  * Given a parking lot with 50 spaces 
  * and a helicopter
  * when the vehicle stays for one day
  * then the driver is charged $35
  * and the lot is left with 42 spaces
10. Helicopter, Plenty of space, 2 Days
  * Given a parking lot with 50 spaces 
  * and a helicopter
  * when the vehicle stays for two days
  * then the driver is charged $70
  * and the lot is left with 42 spaces
11. 20% discount for 3 or more days
  * Given a parking lot with 50 spaces 
  * and a bus
  * when the vehicle stays for four days
  * then the driver is charged $28.80
  * and the lot is left with 48 spaces
12. 30% discount for 6 days or more
  * Given a parking lot with 50 spaces 
  * and a normal car
  * when the vehicle stays for eight days
  * then the driver is charged $28 
  * and the lot is left with 49 spaces

## Techniques/Practices

This is what you should be learning through this kata.

[To Be Determined]

## Inspiration

This kata was inspired by https://github.com/kamranahmedse/design-patterns-for-humans. 
