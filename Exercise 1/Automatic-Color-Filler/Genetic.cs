using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Automatic_Color_Filler
{
    public static class Genetic
    {
        private static Random RNG = new Random();
        
        public static int NumberOfGenerations = 0;
        public static Genome FittestGenome;
        public static Population Population;
        public static List<int> FitnessCounter = new List<int>();
        
        /// <summary>
        /// <b>Generates a <see cref="Genome"/> with random sequence of colours.</b>
        /// A Genome has a 32-bit sequence which determines what colour a box has.
        /// Depending on what position a colour is in the sequence, it will appear on the graph.
        ///
        /// Possible bits are:
        /// <list type="bullet">
        /// <item><description><para><em><c>00</c> -> blue</em></para></description></item>
        /// <item><description><para><em><c>01</c> -> red</em></para></description></item>
        /// <item><description><para><em><c>10</c> -> green</em></para></description></item>
        /// <item><description><para><em><c>11</c> -> yellow</em></para></description></item>
        /// </list>
        /// </summary>
        /// <returns>A Genome with random colours.</returns>
        public static Genome Generate_Genome()
        {
            // 00 is blue
            // 01 is red
            // 10 is green
            // 11 is yellow
            Genome genome = new Genome();
            string[] choices = {"00", "01", "10", "11"};
            for (int j = 0; j < 16; j++)
                genome.Sequence.Add(choices[RNG.Next(choices.Length)]);

            return genome;
        }
        
        /// <summary>
        /// Generates a <see cref="Genome"/> population of size n=<see cref="PopulationSize"/>
        /// </summary>
        /// <param name="PopulationSize">The population size of Genomes.</param>
        /// <returns>A population containing n Genomes, all with different colours and fitness.</returns>
        public static Population Generate_Population(int PopulationSize)
        {
            Population population = new Population();
            
            for (int i = 0; i < PopulationSize; i++)
                population.Genomes.Add(Generate_Genome());

            return population;
        }
        
        
        /// <summary>
        /// Select a pair of the fittest Genomes from a Population.
        /// </summary>
        /// <param name="population">A population containing n <see cref="Genome"/>s (where n is greater than 1)</param>
        /// <returns>A population containing two <see cref="Genome"/>s</returns>
        /// <exception cref="Exception">Throws exception when the population contains exactly 0 or 1 Genomes.</exception>
        public static Population Selection_Pair(Population population)
        {
            switch (population.Genomes.Count)
            {
                case 0:
                    throw new Exception("Cannot select pairs from an empty population.");
                case 1:
                    throw new Exception("Pairs have to be selected from a population with at least 2 genomes.");
                default:
                {
                    //σε αυτό το σημείο απλά παραδίνομαι στο Rider.
                    var maxFitness = population.Genomes.OrderByDescending(g => g.Fitness).ToList();
                    return new Population(maxFitness[0], maxFitness[1]);
                }
            }
        }

        /// <summary>
        /// Switches several random bits from two Genomes, leading to a better solution.
        /// </summary>
        /// <param name="a">First Genome</param>
        /// <param name="b">Second Genome</param>
        /// <returns>An array with two Genomes</returns>
        public static Genome[] Single_Point_Crossover(Genome a, Genome b)
        {
            int point = RNG.Next(1, 15);

            var a_ = new Genome();
            var b_ = new Genome();

            for (int i = 0; i < point; i++)
            {
                a_.Sequence.Add(a.Sequence[i]);
                b_.Sequence.Add(b.Sequence[i]);
            }

            for (int i = point; i < 16; i++)
            {
                a_.Sequence.Add(b.Sequence[i]);
                b_.Sequence.Add(a.Sequence[i]);
            }

            return new []{a_, b_};
        }

        
        /// <summary>
        /// Flips one random bit or several random bits in a Genome's sequence.
        /// </summary>
        /// <param name="genome">The Genome that will be mutated.</param>
        /// <param name="entireSequence">If this is true, the chance of bit flipping is applied in the entire sequence. If it is false, then only one random bit will be changed.</param>
        /// <param name="chance">A chance between 0 and 100.</param>
        /// <returns>A mutated Genome (it can be the same as before).</returns>
        public static Genome Mutation(Genome genome, bool entireSequence, int chance)
        {
            if (entireSequence)
            {
                for (int i = 0; i < genome.Sequence.Count; i++)
                {
                    if (RNG.Next(100) >= chance) continue;
                    if (RNG.Next(0, 2) == 1) genome.Sequence[i] = (genome.Sequence[i][0] == '0'? '1' : '0') + genome.Sequence[i].Remove(0, 1);
                    else                     genome.Sequence[i] =  genome.Sequence[i].Substring(1, 1) + (genome.Sequence[i][1] == '0'? '1' : '0');
                }
            }
            else
            {
                var randomIndex = RNG.Next(genome.Sequence.Count);
                if (RNG.Next(100) >= chance)
                    return genome;
                
                if (RNG.Next(0, 2) == 1) genome.Sequence[randomIndex] = (genome.Sequence[randomIndex][0] == '0'? '1' : '0') + genome.Sequence[randomIndex].Remove(0, 1);
                else                     genome.Sequence[randomIndex] =  genome.Sequence[randomIndex].Substring(1, 1) + (genome.Sequence[randomIndex][1] == '0'? '1' : '0');
            }     
            
            return genome;
        }
        
        /// <summary>
        /// Runs a single step of evolution. This is typically run on a Timer.
        /// </summary>
        /// <returns>The fittest <see cref="Genome"/>, the number of Generations and the Fitness of the fittest Genome.</returns>
        public static Tuple<Genome, int, int> RunEvolution()
        {
            Population.Genomes = Population.Genomes.OrderByDescending(g => g.Fitness).ToList();

            FittestGenome = Population.Genomes[0];
            FitnessCounter.Add(FittestGenome.Fitness);

            if (Population.Genomes[0].Fitness == 42)
                return new Tuple<Genome, int, int>(FittestGenome, NumberOfGenerations, FitnessCounter.Last());
            
            if (FitnessCounter.Count > 8 && FitnessCounter.Last() == FitnessCounter[FitnessCounter.Count - 9])
            {
                Population.Genomes.ForEach(o => Mutation(o, false, 100));
                FitnessCounter.Clear();
            }
            
            var nextGeneration = new Population(Population.Genomes[0], Population.Genomes[1]);
            for (int j = 0; j < Population.Genomes.Count/2 + 1; j++)
            {
                var parents = Selection_Pair(Population);
                var offsprings = Single_Point_Crossover(parents.Genomes[0], parents.Genomes[1]);
                offsprings[0] = Mutation(offsprings[0], true, 30);
                offsprings[1] = Mutation(offsprings[1], true, 30);
                nextGeneration.Genomes.Add(offsprings[1]);
                nextGeneration.Genomes.Add(offsprings[0]);  
            }
            
            Population = nextGeneration;
            NumberOfGenerations++;

            return new Tuple<Genome, int, int>(FittestGenome, NumberOfGenerations, FittestGenome.Fitness);
        }
        
        /// <summary>
        /// Runs an entire Evolution to find a solution.
        /// </summary>
        /// <param name="limit">The limit of Generations. If this is 0, there will be no limit.</param>
        /// <returns>The fittest <see cref="Genome"/> and the number of generations it took to get to this Genome.</returns>
        public static Tuple<Genome, int> RunEvolution(int limit)
        {
            if (limit == 0)
                limit = int.MaxValue;

            do
            {
                Population.Genomes = Population.Genomes.OrderByDescending(g => g.Fitness).ToList();

                FittestGenome = Population.Genomes[0];
                FitnessCounter.Add(FittestGenome.Fitness);

                if (Population.Genomes[0].Fitness == 42)
                    return new Tuple<Genome, int>(FittestGenome, NumberOfGenerations);

                if (FitnessCounter.Count > 8 && FitnessCounter.Last() == FitnessCounter[FitnessCounter.Count - 9])
                {
                    Population.Genomes.ForEach(o => Mutation(o, true, 50));
                    FitnessCounter.Clear();
                }

                var nextGeneration = new Population(Population.Genomes[0], Population.Genomes[1]);
                for (int j = 0; j < Population.Genomes.Count / 2 + 1; j++)
                {
                    var parents = Selection_Pair(Population);
                    var offsprings = Single_Point_Crossover(parents.Genomes[0], parents.Genomes[1]);
                    offsprings[0] = Mutation(offsprings[0], true, 30);
                    offsprings[1] = Mutation(offsprings[1], true, 30);
                    nextGeneration.Genomes.Add(offsprings[1]);
                    nextGeneration.Genomes.Add(offsprings[0]);
                }

                Population = nextGeneration;
                NumberOfGenerations++;
            } while (NumberOfGenerations < limit);

            return new Tuple<Genome, int>(FittestGenome, NumberOfGenerations);
        }
    }
}