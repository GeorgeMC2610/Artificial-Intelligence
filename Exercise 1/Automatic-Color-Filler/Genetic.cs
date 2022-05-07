using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Automatic_Color_Filler
{
    public static class Genetic
    {
        public static Random RNG = new Random();
        
        /// <summary>
        /// <b>Generates a <see cref="Genome"/> with a random sequence of colours.</b>
        /// A Genome has a 32-bit sequence which determines what colour a box has.
        /// Possible bits are:
        /// - 00 blue
        /// - 01 red
        /// - 10 green
        /// - 11 yellow
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
        /// <b>Determines how optimal a solution is.</b>
        /// Since all boxes have to be coloured differently compared to their neighbours,
        /// minimum fitness is 0, which means that all boxes have the same colour. Maximum fitness (optimal solution)
        /// is 42, which means that all 16 boxes have different colours compared to their neighbours. 
        /// </summary>
        /// <param name="genome">The given Genome (containing 0 and 1).</param>
        /// <returns></returns>
        public static int Fitness(Genome genome)
        {
            if (genome.Sequence.Count == 0)
                throw new Exception("Cannot determine fitness of an empty genome.");
            
            int fitness = 0;
            
            //fitness goes up by one if the colours are different 
            if (genome.Sequence[0] != genome.Sequence[1]) fitness++;
            if (genome.Sequence[0] != genome.Sequence[2]) fitness++;
            if (genome.Sequence[0] != genome.Sequence[3]) fitness++;
            if (genome.Sequence[0] != genome.Sequence[12]) fitness++;
            if (genome.Sequence[0] != genome.Sequence[14]) fitness++;
            if (genome.Sequence[0] != genome.Sequence[15]) fitness++;
            
            if (genome.Sequence[1] != genome.Sequence[2]) fitness++;
            if (genome.Sequence[1] != genome.Sequence[4]) fitness++;
            if (genome.Sequence[1] != genome.Sequence[7]) fitness++;
            if (genome.Sequence[1] != genome.Sequence[8]) fitness++;
            if (genome.Sequence[1] != genome.Sequence[13]) fitness++;
            if (genome.Sequence[1] != genome.Sequence[14]) fitness++;
            if (genome.Sequence[1] != genome.Sequence[15]) fitness++;

            if (genome.Sequence[2] != genome.Sequence[3]) fitness++;
            if (genome.Sequence[2] != genome.Sequence[4]) fitness++;
            if (genome.Sequence[2] != genome.Sequence[5]) fitness++;
            
            if (genome.Sequence[3] != genome.Sequence[5]) fitness++;
            if (genome.Sequence[3] != genome.Sequence[12]) fitness++;
            
            if (genome.Sequence[4] != genome.Sequence[5]) fitness++;
            if (genome.Sequence[4] != genome.Sequence[6]) fitness++;
            if (genome.Sequence[4] != genome.Sequence[8]) fitness++;
            if (genome.Sequence[4] != genome.Sequence[9]) fitness++;
            
            if (genome.Sequence[5] != genome.Sequence[6]) fitness++;
            if (genome.Sequence[5] != genome.Sequence[10]) fitness++;
            if (genome.Sequence[5] != genome.Sequence[12]) fitness++;
            
            if (genome.Sequence[6] != genome.Sequence[9]) fitness++;
            if (genome.Sequence[6] != genome.Sequence[10]) fitness++;
            
            if (genome.Sequence[7] != genome.Sequence[8]) fitness++;
            if (genome.Sequence[7] != genome.Sequence[13]) fitness++;
            
            if (genome.Sequence[8] != genome.Sequence[9]) fitness++;
            if (genome.Sequence[8] != genome.Sequence[11]) fitness++;
            if (genome.Sequence[8] != genome.Sequence[13]) fitness++;
            
            if (genome.Sequence[9] != genome.Sequence[10]) fitness++;
            if (genome.Sequence[9] != genome.Sequence[11]) fitness++;
            
            if (genome.Sequence[10] != genome.Sequence[11]) fitness++;
            if (genome.Sequence[10] != genome.Sequence[12]) fitness++;
            
            if (genome.Sequence[11] != genome.Sequence[12]) fitness++;
            if (genome.Sequence[11] != genome.Sequence[13]) fitness++;
            if (genome.Sequence[11] != genome.Sequence[14]) fitness++;
            
            if (genome.Sequence[12] != genome.Sequence[14]) fitness++;
            
            if (genome.Sequence[13] != genome.Sequence[14]) fitness++;
            
            if (genome.Sequence[14] != genome.Sequence[15]) fitness++;
            
            return fitness;
        }
        
        
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
                    var maxFitness = population.Genomes.OrderByDescending(Fitness).ToList();
                    return new Population(maxFitness[0], maxFitness[1]);
                }
            }
        }

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
        /// Changes one random bit on a Genome.
        /// </summary>
        /// <param name="genome">A non-empty Genome</param>
        /// <returns>A randomly mutated Genome.</returns>
        public static Genome Mutation(Genome genome)
        {
            int random_index = RNG.Next(genome.Sequence.Count);

            if (RNG.Next(0, 2) == 1) genome.Sequence[random_index] = (genome.Sequence[random_index][0] == '0'? '1' : '0') + genome.Sequence[random_index].Remove(0, 1);
            else                     genome.Sequence[random_index] =  genome.Sequence[random_index].Substring(1, 1) + (genome.Sequence[random_index][1] == '0'? '1' : '0');
            
            return genome;
        }
    }
}