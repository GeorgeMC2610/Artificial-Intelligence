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
        private static Genome _fittestGenome;
        public static Population Population;
        public static List<int> FitnessCounter = new List<int>();
        
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
        /// Changes several random bits from a Genome.
        /// </summary>
        /// <param name="genome">A non-empty Genome</param>
        /// <returns>A randomly mutated Genome.</returns>
        public static Genome Mutation(Genome genome)
        {
            var randomIndex = RNG.Next(genome.Sequence.Count);

            for (int i = 0; i < genome.Sequence.Count; i++)
            {
                if (RNG.Next(10) >= 3) continue;
                if (RNG.Next(0, 2) == 1) genome.Sequence[i] = (genome.Sequence[i][0] == '0'? '1' : '0') + genome.Sequence[i].Remove(0, 1);
                else                     genome.Sequence[i] =  genome.Sequence[i].Substring(1, 1) + (genome.Sequence[i][1] == '0'? '1' : '0');
            }
            
            return genome;
        }
        
        public static Tuple<Genome, int> RunEvolution()
        {
            Population.Genomes = Population.Genomes.OrderByDescending(Fitness).ToList();

            _fittestGenome = Population.Genomes[0];
            FitnessCounter.Add(Fitness(_fittestGenome));

            if (FitnessCounter.Count > 15 && FitnessCounter.Last() == FitnessCounter[FitnessCounter.Count - 16])
            {
                Population.Genomes.ForEach(o => Mutation(o));
                FitnessCounter.Clear();
            }
            
            if (Fitness(Population.Genomes[0]) == 42)
                return new Tuple<Genome, int>(_fittestGenome, NumberOfGenerations);
            
            
            var nextGeneration = new Population(Population.Genomes[0], Population.Genomes[1]);
            for (int j = 0; j < Population.Genomes.Count/2 + 1; j++)
            {
                var parents = Selection_Pair(Population);
                var offsprings = Single_Point_Crossover(parents.Genomes[0], parents.Genomes[1]);
                offsprings[0] = Mutation(offsprings[0]);
                offsprings[1] = Mutation(offsprings[1]);
                nextGeneration.Genomes.Add(offsprings[1]);
                nextGeneration.Genomes.Add(offsprings[0]);  
            }

            Population = nextGeneration;
            NumberOfGenerations++;

            return new Tuple<Genome, int>(_fittestGenome, NumberOfGenerations);
        }
    }
}