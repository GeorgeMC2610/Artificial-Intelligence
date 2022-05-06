using System.Collections.Generic;
using System.Linq;

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

        public Population(params Genome[] genomes)
        {
            Genomes = genomes.ToList();
        }

        public List<Genome> Genomes;
    }
}