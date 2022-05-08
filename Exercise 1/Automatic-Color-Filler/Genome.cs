using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Automatic_Color_Filler
{
    public class Genome
    {
        public Genome()
        {
            Sequence = new List<string>();
        }
        
        public List<string> Sequence;

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