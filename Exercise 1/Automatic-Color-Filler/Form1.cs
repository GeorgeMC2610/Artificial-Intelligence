using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automatic_Color_Filler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerateGenome_Click(object sender, EventArgs e)
        {
            var length = 15;
            var population = Genetic.Generate_Population(length);
            var max_fitness = (from genome in population.Genomes select Genetic.Fitness(genome)).Max();
            var fittest_genome = (from genome in population.Genomes where Genetic.Fitness(genome) == max_fitness select genome).First();

            labelFitness.Text = $@"Fitness: {Genetic.Fitness(fittest_genome)}";
            labelGenome.Text = $@"Fittest genome from {length} total genomes is: {string.Join("", fittest_genome.Sequence)}";
        }
    }
}