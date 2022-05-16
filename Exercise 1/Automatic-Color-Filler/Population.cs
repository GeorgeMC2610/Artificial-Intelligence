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
        
        public List<Genome> Genomes;

        public Population(List<Genome> Genomes)
        {
            this.Genomes = Genomes;
        }

        public Population(params Genome[] genomes)
        {
            Genomes = genomes.ToList();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Population);
        }

        public bool Equals(Population population)
        {
            if (population == null)
                return false;

            if (population.Genomes.Count != Genomes.Count)
                return false;
            return !population.Genomes.Where((t, i) => !Genomes[i].Equals(t)).Any();
        }
    }
}