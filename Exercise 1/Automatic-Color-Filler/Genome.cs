using System;
using System.Collections.Generic;
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
            for (int i = 0; i < 16; i++)
                newSequence.Add(string.Concat(sequence[i], sequence[i + 1]));

            Sequence = newSequence;
        }

        public string DisplaySequence()
        {
            return string.Join("", Sequence);
        }
    }
}