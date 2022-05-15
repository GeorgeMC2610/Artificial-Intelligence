# Artificial Intelligence (GR: Τεχνητή Νοημοσύνη)
## 6th Semester Course
### The goal was to make a program that would find a solution to a problem using Genetic Algorithms. Two basic problems were given; The Traveling Salesman Problem and a Constraint Satisfaction Problem. Students had to make a program for one of those two problems, to get the 100% of the grade.

***Exercise A***: Make a program that generates a solution for the Traveling Salesman Problem as it is depicted below:

![ex1](https://github.com/GeorgeMC2610/Artificial-Intelligence/blob/master/Exercise%201/schema1.png)


***Exercise B***: Make a program that generates a solution for the following Constraint Satisfaction Problem. All boxes have to have different colours compared to their neighbours. Four colours are available: Blue, Red, Green, Yellow.

![ex2](https://github.com/GeorgeMC2610/Artificial-Intelligence/blob/master/Exercise%201/schema2.png)


**CLARIFICATIONS**
+ Use genetic algorithms to find any solution.
+ Use a random number for the starting population.
+ Construct a fitness function.
+ Generate offsprings using a single point crossover function.
+ Use mutations to find better solutions.

# My Approach with C#
## I made a WinForms application, to visualize how every box should be coloured correctly. In this app, the user clicks the button and the program starts generating solutions until it finds the best one.

### How is a solution represented?

Since we have four possible colours, we can define them to be represented as 2-bit numbers:
- 00 is blue
- 01 is red
- 10 is green
- 11 is yellow

Also, there are 16 boxes to give colour to. Which means that we have 2 bits for every box; 16 × 2 = 32 bits to define a solution. For example, "0000000000000000000000000000000000" means that all boxes have the same colour (blue).
