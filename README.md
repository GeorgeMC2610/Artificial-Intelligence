# Artificial Intelligence
### 6th Semester Course


The goal was to make a program that would find a solution to a problem using Genetic Algorithms. Two basic problems were given; The Traveling Salesman Problem and a Constraint Satisfaction Problem. Students had to make a program for one of those two problems, to get the 100% of the grade.

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

<br>

# My Approach with C#
### I made a Windows Forms application, to visualize how every box should be coloured correctly. In this app, the user clicks the button and the program starts generating solutions until it finds the best one.

This CSP has many optimal solutions, so the goal is to find one of them. In the main loop, the program generates a starting population of genomes, all containing randomly generated solutions. The Genomes will be sorted by their **fitness score** and the fittest genome will be held as the one to remain, in order to **generate offsprings** based on it. **The program doesn't stop until a genome has a fitness score of 42, which means it's an optimal solution**.

## How is a solution represented?

Since we have four possible colours, we can define them to be represented as 2-bit numbers:
- 00 is blue
- 01 is red
- 10 is green
- 11 is yellow

Also, there are 16 boxes to give colour to. Which means that we have 2 bits for every box; 16 × 2 = 32 bits to define a solution. For example, "0000000000000000000000000000000000" means that all boxes have the same colour (blue).

</br>

## How does the fitness function work?

I created the `Genome` class. A `Genome` has an attribute; the `Sequence`, which is a list of Strings representing a solution, as it is explained above. ***The `Fitness` attribute, is an integer number. It goes up by one, for every box that has a different colour compared to a neighbour.*** Minimum fitness is 0, which means that all boxes have the same colour. Maximum fitness is 42, which means that there is no box that has the same colour as any of its neighbours.

</br>

## How is the number of the starting population determined?

**The optimal starting population is 15 genomes.** Although, the user has the capability to change this number, through a numeric up-down control. Minimum starting population is 3 and maximum is 150. Contrary to what one would assume, adding more genomes in the starting population, does **not** necessarily mean that the program will find a solution faster. Finding a solution is single-handedly bound to random chance. 

</br>

## How are offsprings generated?

In the main loop, the fittest solutions are selected in order to generate offsprings. While keeping the fittest genome unaltered, the program generates offsprings using a crossover function. **The crossover function takes two genomes and interchanges their bits in a single point (Single-Point Crossover function).** The point, where the two solutions start to swap, is selected randomly. **The fittest genomes are more likely to be selected and to be bred, which increases the chance of finding a better solution**.

</br>

## How often does a mutation happen?

In the main loop, **there is a 30% for a mutation to happen on an offspring**. A mutation usually happens to one bit only, but it is possible to apply random chance to all bits. Although, if the program gets stuck to a local maxima for 8 times in a row, it mutates all genomes of the population. This happens because the best solution might not be able to be found otherwise.

</br>

# Using The App

This application is available for download and can be opened by navigating through the bin/Debug folders. Make sure you are running the app in a **Windows (7/8/10/11) Machine**.

<br>

## Opening Screen

This is what you see, once you open the app. At first, all boxes start with no colour.

<img src="Exercise 1/opening.png" alt="Opening Screen" width=75%>

<br>

## Finding A Solution

In order to find a solution click on the ***Start Finding Solutions*** button. The program will start the process of finding a "best solution" and will stop when it finds one. **Note that, sometimes, the program will take a notably long time to finish.**

<br>

### Iterating Through Generations

It is rather interesting to see how the program finds a best solution, by seeing **the fittest genome from each generation**. Every half a second (as this is the default interval) the program will jump to the next generation; each time showing the fittest genome and how it got to the end. As said before, the program stops until the program actually finds a best solution (the following example was rather fast).

<img src="Exercise 1/csp4.gif" alt="Iteration" width=75%>

<br>

### Without Iterating Through Generations

If the user wants to seek for a best solution immediately, the checkbox ***Iterate Through Generations*** must be unticked. With this setting turned off, the program finds a best solution faster, **but it might not respond until then**.

<img src="Exercise 1/csp3.gif" alt="No Iteration" width=75%>

<br>

## Manually Handling A Genome

The user is able to manually solve this problem and examine a solution using the textbox located in the bottom-left of the application. The solution can be tested by pressing the ***Calculate Fitness*** button and then checking its fitness score. Some useful things to remember:
+ 0 fitness is the lowest score (means that every box has the same colour as all of its neighbours).
+ 42 fitness is the best score (means that no box has the same colour as any of its neighbours).
+ There must be exactly 32 bits in a solution.
