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

        private void buttonGenerateGenome_Click(object sender, EventArgs e)
        {
            if (checkBoxIterateGens.Checked)
            {
                timer1.Enabled = !timer1.Enabled;
                buttonCustomGenome.Enabled = numericUpDownInterval.Enabled = numericUpDownStartPop.Enabled = !timer1.Enabled;
            
                Genetic.Population = Genetic.Generate_Population((int) numericUpDownStartPop.Value);
                Genetic.FittestGenome = null;
                Genetic.NumberOfGenerations = 0;
                Genetic.FitnessCounter.Clear();
            
                buttonGenerateGenome.BackColor = timer1.Enabled ? Color.LightCoral : Color.DeepSkyBlue;
                buttonGenerateGenome.Text = timer1.Enabled ? "Stop Evolution" : "Start Over";
            }
            else
            {
                Genetic.Population = Genetic.Generate_Population((int) numericUpDownStartPop.Value);
                Genetic.FittestGenome = null;
                Genetic.NumberOfGenerations = 0;
                Genetic.FitnessCounter.Clear();

                var (genome, generation) = Genetic.RunEvolution(0);
                
                AnalyzeSequences(genome, generation);
            }
            
        }

        private Label GetLabelByName(string name)
        {
            var control = from label in panel1.Controls.Cast<Control>() where label.Name == name select label;
            if (!control.Any())
                return null;
            
            return (Label) control.First();
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            var (genome, generation, fitness) = Genetic.RunEvolution();
            
            AnalyzeSequences(genome, generation);

            if (fitness < 42) return;
            buttonGenerateGenome.PerformClick();
            timer1.Enabled = false;
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
            AnalyzeSequences(g1, -1);
        }

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (double) numericUpDownInterval.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 16; i++)
            {
                GetLabelByName($"label{i}").Text = "";
                GetLabelByName($"label{i}").BorderStyle = BorderStyle.FixedSingle;
            }

            foreach (Control c in panel1.Controls)
                c.Visible = false;
        }

        private void AnalyzeSequences(Genome genome, int generations)
        {
            foreach (Control c in panel1.Controls)
                c.Visible = true;

            panel1.BackgroundImage = null;
            
            labelFitness.Text = $@"Sequence of solution: {genome.DisplaySequence()}. Fitness: {Genetic.Fitness(genome)}";
            labelGenome.Text = generations == -1 ? @"(Custom Genome)" : $@"Generation: {generations}";
            ApplyColors(genome);
        }
        
        private void ApplyColors(Genome genome)
        {
            var colors = new Dictionary<string, Color>()
            {
                {"00", Color.CornflowerBlue},
                {"01", Color.IndianRed},
                {"10", Color.LightGreen},
                {"11", Color.Yellow}
            };

            for (int i = 0; i < 16; i++)
                GetLabelByName($"label{i + 1}").BackColor = GetLabelByName($"label{i + 1}_{i + 1}").BackColor = colors[genome.Sequence[i]];
        }
    }
}