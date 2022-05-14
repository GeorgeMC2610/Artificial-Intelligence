using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Automatic_Color_Filler
{
    public class Genome
    {
        //Constructor
        public Genome()
        {
            Sequence = new List<string>();
        }
        
        //fields
        public List<string> Sequence;
        public int Fitness => _Fitness();

        public void ConvertStringToSequence(string sequence)
        {
            if (sequence.Length != 32)
                throw new Exception("A sequence must be of length 32");
            
            Sequence.Clear();
            
            var newSequence = new List<string>();
            for (int i = 0; i < 32; i+=2)
                newSequence.Add(string.Concat(sequence[i], sequence[i + 1]));

            Sequence = newSequence;
        }

        public string DisplaySequence()
        {
            return string.Join("", Sequence);
        }
        
        /// <summary>
        /// <b>Determines how optimal a solution is.</b>
        /// Since all boxes have to be coloured differently compared to their neighbours,
        /// minimum fitness is 0, which means that all boxes have the same colour. Maximum fitness (optimal solution)
        /// is 42, which means that all 16 boxes have different colours compared to their neighbours. 
        /// </summary>
        /// <returns>A number between 0 and 42 (inclusive).</returns>
        private int _Fitness()
        {
            if (this.Sequence.Count == 0)
                throw new Exception("Cannot determine fitness of an empty genome.");
            
            int fitness = 0;
            
            //fitness goes up by one if the colours are different 
            if (this.Sequence[0] != this.Sequence[1]) fitness++;
            if (this.Sequence[0] != this.Sequence[2]) fitness++;
            if (this.Sequence[0] != this.Sequence[3]) fitness++;
            if (this.Sequence[0] != this.Sequence[12]) fitness++;
            if (this.Sequence[0] != this.Sequence[14]) fitness++;
            if (this.Sequence[0] != this.Sequence[15]) fitness++;
            
            if (this.Sequence[1] != this.Sequence[2]) fitness++;
            if (this.Sequence[1] != this.Sequence[4]) fitness++;
            if (this.Sequence[1] != this.Sequence[7]) fitness++;
            if (this.Sequence[1] != this.Sequence[8]) fitness++;
            if (this.Sequence[1] != this.Sequence[13]) fitness++;
            if (this.Sequence[1] != this.Sequence[14]) fitness++;
            if (this.Sequence[1] != this.Sequence[15]) fitness++;

            if (this.Sequence[2] != this.Sequence[3]) fitness++;
            if (this.Sequence[2] != this.Sequence[4]) fitness++;
            if (this.Sequence[2] != this.Sequence[5]) fitness++;
            
            if (this.Sequence[3] != this.Sequence[5]) fitness++;
            if (this.Sequence[3] != this.Sequence[12]) fitness++;
            
            if (this.Sequence[4] != this.Sequence[5]) fitness++;
            if (this.Sequence[4] != this.Sequence[6]) fitness++;
            if (this.Sequence[4] != this.Sequence[8]) fitness++;
            if (this.Sequence[4] != this.Sequence[9]) fitness++;
            
            if (this.Sequence[5] != this.Sequence[6]) fitness++;
            if (this.Sequence[5] != this.Sequence[10]) fitness++;
            if (this.Sequence[5] != this.Sequence[12]) fitness++;
            
            if (this.Sequence[6] != this.Sequence[9]) fitness++;
            if (this.Sequence[6] != this.Sequence[10]) fitness++;
            
            if (this.Sequence[7] != this.Sequence[8]) fitness++;
            if (this.Sequence[7] != this.Sequence[13]) fitness++;
            
            if (this.Sequence[8] != this.Sequence[9]) fitness++;
            if (this.Sequence[8] != this.Sequence[11]) fitness++;
            if (this.Sequence[8] != this.Sequence[13]) fitness++;
            
            if (this.Sequence[9] != this.Sequence[10]) fitness++;
            if (this.Sequence[9] != this.Sequence[11]) fitness++;
            
            if (this.Sequence[10] != this.Sequence[11]) fitness++;
            if (this.Sequence[10] != this.Sequence[12]) fitness++;
            
            if (this.Sequence[11] != this.Sequence[12]) fitness++;
            if (this.Sequence[11] != this.Sequence[13]) fitness++;
            if (this.Sequence[11] != this.Sequence[14]) fitness++;
            
            if (this.Sequence[12] != this.Sequence[14]) fitness++;
            
            if (this.Sequence[13] != this.Sequence[14]) fitness++;
            
            if (this.Sequence[14] != this.Sequence[15]) fitness++;
            
            return fitness;
        }

        public bool Equals(Genome genome)
        {
            if (genome == null)
                return false;

            if (genome.Sequence.Count != Sequence.Count)
                return false;

            return !genome.Sequence.Where((t, i) => Sequence[i] != t).Any();
        }
    }
}