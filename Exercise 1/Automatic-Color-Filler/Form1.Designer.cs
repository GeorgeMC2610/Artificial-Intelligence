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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStartPop = new System.Windows.Forms.NumericUpDown();
            this.labelStartingPopulation = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownGenLimit = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownStartPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownGenLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateGenome
            // 
            this.buttonGenerateGenome.Location = new System.Drawing.Point(12, 501);
            this.buttonGenerateGenome.Name = "buttonGenerateGenome";
            this.buttonGenerateGenome.Size = new System.Drawing.Size(931, 44);
            this.buttonGenerateGenome.TabIndex = 0;
            this.buttonGenerateGenome.Text = "Apply Random Colors";
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::Automatic_Color_Filler.Properties.Resources.schema2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(242, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 383);
            this.panel1.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(364, 328);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 25);
            this.label16.TabIndex = 14;
            this.label16.Text = "16";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(271, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 25);
            this.label15.TabIndex = 13;
            this.label15.Text = "15";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(187, 292);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "14";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(328, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "13";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(220, 253);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 25);
            this.label12.TabIndex = 10;
            this.label12.Text = "12";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(271, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 25);
            this.label11.TabIndex = 9;
            this.label11.Text = "11";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(187, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "10";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(131, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "9";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(75, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "8";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(239, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(292, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "6";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(167, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "5";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(364, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "4";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(220, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(74, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(239, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // numericUpDownStartPop
            // 
            this.numericUpDownStartPop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownStartPop.Location = new System.Drawing.Point(207, 473);
            this.numericUpDownStartPop.Name = "numericUpDownStartPop";
            this.numericUpDownStartPop.Size = new System.Drawing.Size(54, 26);
            this.numericUpDownStartPop.TabIndex = 4;
            this.numericUpDownStartPop.Value = new decimal(new int[] {15, 0, 0, 0});
            // 
            // labelStartingPopulation
            // 
            this.labelStartingPopulation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelStartingPopulation.Location = new System.Drawing.Point(12, 475);
            this.labelStartingPopulation.Name = "labelStartingPopulation";
            this.labelStartingPopulation.Size = new System.Drawing.Size(189, 23);
            this.labelStartingPopulation.TabIndex = 5;
            this.labelStartingPopulation.Text = "Starting Population:";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(12, 441);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 23);
            this.label17.TabIndex = 6;
            this.label17.Text = "Generation Limit:";
            // 
            // numericUpDownGenLimit
            // 
            this.numericUpDownGenLimit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.numericUpDownGenLimit.Location = new System.Drawing.Point(176, 438);
            this.numericUpDownGenLimit.Maximum = new decimal(new int[] {250, 0, 0, 0});
            this.numericUpDownGenLimit.Name = "numericUpDownGenLimit";
            this.numericUpDownGenLimit.Size = new System.Drawing.Size(57, 26);
            this.numericUpDownGenLimit.TabIndex = 7;
            this.numericUpDownGenLimit.Value = new decimal(new int[] {50, 0, 0, 0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 557);
            this.Controls.Add(this.numericUpDownGenLimit);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelStartingPopulation);
            this.Controls.Add(this.numericUpDownStartPop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelGenome);
            this.Controls.Add(this.labelFitness);
            this.Controls.Add(this.buttonGenerateGenome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownStartPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericUpDownGenLimit)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownGenLimit;

        private System.Windows.Forms.Label labelStartingPopulation;

        private System.Windows.Forms.NumericUpDown numericUpDownStartPop;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label labelGenome;

        private System.Windows.Forms.Button buttonGenerateGenome;
        private System.Windows.Forms.Label labelFitness;

        #endregion
    }
}