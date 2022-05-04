using System;

namespace Automatic_Color_Filler
{
    public static class Genetic
    {
        private static Genome Generate_Genomes(int length)
        {
            // 00 is blue
            // 01 is red
            // 10 is green
            // 11 is yellow
            Genome genome = new Genome();
            string[] choices = {"00", "01", "10", "11"};
            
            //create a population
            for (int i = 0; i < length; i++)
                //and generate random colors
                for (int j = 0; j < 32; j++)
                    genome.Sequences.Add(choices[new Random().Next(choices.Length)]);

            return genome;
        }

        public static Population Generate_Population(int PopulationSize, int GenomeLength)
        {
            var population = new Population();
            
            for (int i = 0; i < PopulationSize; i++)
                population.Genomes.Add(Generate_Genomes(GenomeLength));

            return population;
        }

        public static int Fitness(Genome genome)
        {
            
        }
    }
}