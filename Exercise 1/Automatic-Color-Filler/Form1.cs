﻿using System;
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
            timer1.Enabled = !timer1.Enabled;
            buttonCustomGenome.Enabled = numericUpDownInterval.Enabled = numericUpDownStartPop.Enabled = !timer1.Enabled;
            
            Genetic.Population = Genetic.Generate_Population((int) numericUpDownStartPop.Value);
            Genetic.FittestGenome = null;
            Genetic.NumberOfGenerations = 0;
            Genetic.FitnessCounter.Clear();
            
            buttonGenerateGenome.BackColor = timer1.Enabled ? Color.LightCoral : Color.DeepSkyBlue;
            buttonGenerateGenome.Text = timer1.Enabled ? "Stop Evolution" : "Start Over";
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
            var result = Genetic.RunEvolution();
            
            labelFitness.Text = $@"Sequence of solution: {result.Item1.DisplaySequence()}. Fitness: {Genetic.Fitness(result.Item1)}";
            labelGenome.Text = $@"Generation: {result.Item2}";
            ApplyColors(result.Item1);

            if (Genetic.Fitness(result.Item1) == 42)
            {
                buttonGenerateGenome.PerformClick();
                timer1.Enabled = false;
            }
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

        private void numericUpDownInterval_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = (double) numericUpDownInterval.Value;
        }
    }
}