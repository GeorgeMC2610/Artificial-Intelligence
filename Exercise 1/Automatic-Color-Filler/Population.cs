using System.Collections.Generic;

namespace Automatic_Color_Filler
{
    public class Population
    {
        public Population()
        {
            Genomes = new List<Genome>();
        }

        public Population(List<Genome> Genomes)
        {
            this.Genomes = Genomes;
        }

        public List<Genome> Genomes;
    }
}