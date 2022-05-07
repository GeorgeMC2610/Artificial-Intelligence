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
            Genome g1 = Genetic.Generate_Genome();
            Genome g2 = Genetic.Generate_Genome();

            var new_population = Genetic.Single_Point_Crossover(g1, g2);
            
            //var (item1, item2) = RunEvolution(2, Genetic.Generate_Population(15));

            labelFitness.Text = $@"Starting solutions: {string.Join("", g1.Sequence)}, {string.Join("", g2.Sequence)}";
            labelGenome.Text  = $@"Final___ solutions: {string.Join("", new_population[0].Sequence)}, {string.Join("", new_population[1].Sequence)}";
            
            //ApplyColorToLabels(item1);
        }

        private Tuple<Genome, int> RunEvolution(int generationLimit, Population population)
        {
            int numberOfGenerations = 0;
            Genome fittestGenome = null;
            
            for (int i = 0; i < generationLimit; i++)
            {
                population.Genomes = population.Genomes.OrderByDescending(Genetic.Fitness).ToList();

                if (Genetic.Fitness(population.Genomes[0]) == 42)
                {
                    fittestGenome = population.Genomes[0];
                    break;
                }

                var nextGeneration = new Population(population.Genomes[0], population.Genomes[1]);
                for (int j = 0; j < population.Genomes.Count/2 - 1; i++)
                {
                    var parents = Genetic.Selection_Pair(population);
                    var offsprings = Genetic.Single_Point_Crossover(parents.Genomes[0], parents.Genomes[1]);
                    offsprings[0] = Genetic.Mutation(offsprings[0]);
                    offsprings[1] = Genetic.Mutation(offsprings[1]);
                    nextGeneration.Genomes.Add(offsprings[1]);
                    nextGeneration.Genomes.Add(offsprings[0]);  
                }

                population = nextGeneration;
                numberOfGenerations++;
            }
            
            return new Tuple<Genome, int>(fittestGenome, numberOfGenerations);
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