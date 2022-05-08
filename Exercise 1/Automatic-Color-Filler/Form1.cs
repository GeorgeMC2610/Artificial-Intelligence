using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Automatic_Color_Filler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int NumberOfGenerations = 0;
        private static Genome FittestGenome;
        private static Population _population;
        private bool EnableTimer = false;
        private List<int> FitnessCounter = new List<int>();

        private void buttonGenerateGenome_Click(object sender, EventArgs e)
        {
            //Genome g1 = new Genome();
            // g2 = new Genome();
            
            //g1.ConvertStringToSequence("00000000000000000000000000000000");

            //var new_population = Genetic.Single_Point_Crossover(g1, g2);
            
            //var (item1, item2) = Genetic.RunEvolution(int.MaxValue, Genetic.Generate_Population((int)numericUpDownStartPop.Value));

            //labelFitness.Text = $@"Sequence of solution: {item1.DisplaySequence()}. Fitness: {Genetic.Fitness(Genetic.FittestGenome)}";
            //labelGenome.Text = $@"Total generations: {item2}";

            _population = Genetic.Generate_Population((int) numericUpDownStartPop.Value);
            NumberOfGenerations = 0;
            FitnessCounter.Clear();
            timer1.Enabled = !timer1.Enabled;
        }

        private void ApplyColors(Genome genome)
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
            
            return control.First();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            _population.Genomes = _population.Genomes.OrderByDescending(Genetic.Fitness).ToList();

            FittestGenome = _population.Genomes[0];
            FitnessCounter.Add(Genetic.Fitness(FittestGenome));

            if (FitnessCounter.Count > 15 && FitnessCounter.Last() == FitnessCounter[FitnessCounter.Count - 16])
            {
                labelGenome.ForeColor = Color.Brown;
                _population.Genomes.ForEach(o => Genetic.Mutation(o));
            }
            
            if (Genetic.Fitness(_population.Genomes[0]) == 42)
            {
                timer1.Enabled = false;
                
                labelFitness.Text = $@"Sequence of solution: {FittestGenome.DisplaySequence()}. Fitness: {Genetic.Fitness(FittestGenome)}";
                labelGenome.Text = $@"Generation: {NumberOfGenerations}";
                ApplyColors(FittestGenome);
                
                return;
            }
            
            var nextGeneration = new Population(_population.Genomes[0], _population.Genomes[1]);
            for (int j = 0; j < _population.Genomes.Count/2 + 1; j++)
            {
                var parents = Genetic.Selection_Pair(_population);
                var offsprings = Genetic.Single_Point_Crossover(parents.Genomes[0], parents.Genomes[1]);
                offsprings[0] = Genetic.Mutation(offsprings[0]);
                offsprings[1] = Genetic.Mutation(offsprings[1]);
                nextGeneration.Genomes.Add(offsprings[1]);
                nextGeneration.Genomes.Add(offsprings[0]);  
            }

            _population = nextGeneration;
            NumberOfGenerations++;
            
            labelFitness.Text = $@"Sequence of solution: {FittestGenome.DisplaySequence()}. Fitness: {Genetic.Fitness(FittestGenome)}";
            labelGenome.Text = $@"Generation: {NumberOfGenerations}";
            ApplyColors(FittestGenome);
        }

        private void buttonCustomGenome_Click(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBoxCustomGenome.Text, "[01]{32}"))
            {
                MessageBox.Show(@"There must be exactly 32 zeros and/or ones in a genome.", @"Wrong Sequence", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            Genome g1 = new Genome();
            g1.ConvertStringToSequence(textBoxCustomGenome.Text);
            labelFitness.Text = $@"Sequence of solution: {g1.DisplaySequence()}. Fitness: {Genetic.Fitness(g1)}";
            labelGenome.Text = $@"Custom Genome.";
            ApplyColors(g1);
        }
    }
}