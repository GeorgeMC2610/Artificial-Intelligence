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
            
            ApplyColorToLabels(fittest_genome);
        }

        private void ApplyColorToLabels(Genome genome)
        {
            for (int i = 0; i < 16; i++)
            {
                switch (genome.Sequence[i])
                {
                    case "00":
                        GetLabelByName($"label{i + 1}").BackColor = Color.CornflowerBlue;
                        break;
                    case "01":
                        GetLabelByName($"label{i + 1}").BackColor = Color.IndianRed;
                        break;
                    case "10":
                        GetLabelByName($"label{i + 1}").BackColor = Color.LightGreen;
                        break;
                    case "11":
                        GetLabelByName($"label{i + 1}").BackColor = Color.Yellow;
                        break;
                }
            }
        }

        private Control GetLabelByName(string name)
        {
            var control = from label in panel1.Controls.Cast<Control>() where label.Name == name select label;
            if (!control.Any())
                return null;
            else
                return control.First();
        }
    }
}