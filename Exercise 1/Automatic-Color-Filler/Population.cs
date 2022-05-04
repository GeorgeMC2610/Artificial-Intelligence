using System.Collections.Generic;

namespace Automatic_Color_Filler
{
    public class Population
    {
        public Population()
        {
            Genomes = new List<Genome>();
        }

        public List<Genome> Genomes;
    }
}