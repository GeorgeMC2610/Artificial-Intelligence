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
            var genome = Genetic.Generate_Genome();

            labelFitness.Text = $@"Fitness: {Genetic.Fitness(genome)}";
            labelGenome.Size = new Size(99999, 99);
            labelGenome.Text = $@"Genome: {string.Join("", genome.Sequence)}";
        }
    }
}