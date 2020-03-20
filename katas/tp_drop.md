In honor of the Covid-19 Pandemic of 2020…

# The TP Drop Kata 
by Byron Sommardahl

### Summary:
Special load-bearing, long-distance, autonomous drones have been developed by the government to deploy much needed rolls of toilet paper to designated drop points around the zone.

Your job is to build a dispatch system that will help the drones deploy TP in an efficient way while serving the most people as quickly as possible.

### Rules:

We have 3 special drones with varying capabilities:
The Charmin Shredder
Range 5 miles
Max load 3 rolls
Top speed 15 mph
Ascent/descent time: 2 min
The Bounty Blitz
Range 10 miles
Max load 5 rolls
Top speed 10 mph 
Ascent/descent time: 3 min
The Scott Scooter
Range 20 miles
Max load 1 roll
Top speed 30 mph 
Ascent/descent time: 1 min

We have 400 families in the zone. For this exercise, the distance from the distribution center for each family should be randomly generated between 1 and 20 miles (use time as seed).

Each family gets one roll per shipment as supplies last.

If a family didn’t get a roll last shipment, they should get a roll on the next shipment.

Every hour, a new shipment of 300 rolls of TP is received at the distribution center. 

### Your Task:
- Write a program that creates a computer-readable plan to dispatch these three drones enough times to finish delivering 4 shipments of TP.

- Write a program that can read the plan and dispatch the drones with their instructions.
- Once the plan is made, each family should receive a notification alerting them of when they should expect their TP deliveries (one digest message).

### Process:

Build a plan generator that takes in addresses and returns a plan
Take one address within one drone’s range and generate one plan step


Build a random address generator (pre-built)


Build a dispatcher that takes in a plan and sends out the drones
Build a shipment simulator (300 rolls per shipment, each hour)



