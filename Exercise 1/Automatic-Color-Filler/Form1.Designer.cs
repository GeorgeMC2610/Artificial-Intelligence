namespace Automatic_Color_Filler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerateGenome = new System.Windows.Forms.Button();
            this.labelFitness = new System.Windows.Forms.Label();
            this.labelGenome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerateGenome
            // 
            this.buttonGenerateGenome.Location = new System.Drawing.Point(12, 501);
            this.buttonGenerateGenome.Name = "buttonGenerateGenome";
            this.buttonGenerateGenome.Size = new System.Drawing.Size(931, 44);
            this.buttonGenerateGenome.TabIndex = 0;
            this.buttonGenerateGenome.Text = "Generate Random Genome";
            this.buttonGenerateGenome.UseVisualStyleBackColor = true;
            this.buttonGenerateGenome.Click += new System.EventHandler(this.buttonGenerateGenome_Click);
            // 
            // labelFitness
            // 
            this.labelFitness.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelFitness.Location = new System.Drawing.Point(12, 9);
            this.labelFitness.Name = "labelFitness";
            this.labelFitness.Size = new System.Drawing.Size(892, 23);
            this.labelFitness.TabIndex = 1;
            this.labelFitness.Text = "Fitness";
            // 
            // labelGenome
            // 
            this.labelGenome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelGenome.Location = new System.Drawing.Point(12, 32);
            this.labelGenome.Name = "labelGenome";
            this.labelGenome.Size = new System.Drawing.Size(892, 23);
            this.labelGenome.TabIndex = 2;
            this.labelGenome.Text = "Genome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 557);
            this.Controls.Add(this.labelGenome);
            this.Controls.Add(this.labelFitness);
            this.Controls.Add(this.buttonGenerateGenome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelGenome;

        private System.Windows.Forms.Button buttonGenerateGenome;
        private System.Windows.Forms.Label labelFitness;

        #endregion
    }
}