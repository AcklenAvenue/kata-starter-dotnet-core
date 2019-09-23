# Parking Lot Kata

## Story

We have a new "smart lot" parking lot. Our parking lot can host many types of vehicles and promotes environmental responsibility by giving discounts to vehicles that are easier on the environment. Even though we have a limited number of spaces today, we hope to expand someday. Also, we hope to start with simple vehicles and start generating revenue before adding more complicated vehicle types.

## Rules

* Strict adherence to "open/closed"

## Specs

* Normal Car, Plenty of Space
  * Given a parking lot with 50 spaces 
  * and a normal car
  * when the vehicle enters the lot
  * then the driver is charged $5 
  * and the lot is left with 49 spaces
* Normal Car, One Space Left
  * Given a parking lot with 1 spaces 
  * and a normal car
  * when the vehicle enters the lot
  * then the driver is charged $5 
  * and the lot is left with 0 spaces
* Normal Car, No Space
  * Given a parking lot with 0 spaces 
  * and a normal car
  * when the vehicle enters the lot
  * then the driver is charged $0
  * and the car is rejected
* Electric Car, Plenty of Space
  * Given a parking lot with 50 spaces 
  * and an electric car
  * when the vehicle enters the lot
  * then the driver is charged $2.50 (50% discount)
  * and the lot is left with 49 spaces
* Motocycle, Plenty of Space
  * Given a parking lot with 50 spaces 
  * and a motorcycle
  * when the vehicle enters the lot
  * then the driver is charged $2.50
  * and the lot is left with 49.5 spaces


## Techniques/Practices

This is what you should be learning through this kata.

## Inspiration

This kata was inspired by https://github.com/kamranahmedse/design-patterns-for-humans. 
