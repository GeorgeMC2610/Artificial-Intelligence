using System;
using System.Collections.Generic;

namespace Automatic_Color_Filler
{
    public static class Genetic
    {
        public static Random RNG = new Random();
        
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

        public static Population Generate_Population(int PopulationSize)
        {
            Population population = new Population();
            
            for (int i = 0; i < PopulationSize; i++)
                population.Genomes.Add(Generate_Genome());

            return population;
        }

        public static int Fitness(Genome genome)
        {
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

        public static Population Selection_Pair()
        {
            return null;
        }

        public static Tuple<Genome, Genome> Single_Point_Crossover(Genome a, Genome b)
        {
            int point = RNG.Next(1, a.Sequence.Count - 1);

            //ΓΙΝΕΤΑΙ ΑΥΤΟ;!!
            for (int i = 1; i < point; i++)
                (a.Sequence[i], b.Sequence[i]) = (b.Sequence[i], a.Sequence[i]);
            
            return new Tuple<Genome, Genome>(a, b);
        }

        public static Genome Mutation(Genome genome)
        {
            int random_index = RNG.Next(genome.Sequence.Count);

            if (RNG.Next(0, 2) == 1) genome.Sequence[random_index] = (genome.Sequence[random_index][0] == '0'? '1' : '0') + genome.Sequence[random_index].Remove(0, 1);
            else                     genome.Sequence[random_index] =  genome.Sequence[random_index].Substring(1, 1) + (genome.Sequence[random_index][1] == '0'? '1' : '0');
            
            return genome;
        }
    }
}