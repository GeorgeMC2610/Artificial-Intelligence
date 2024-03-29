﻿namespace Automatic_Color_Filler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonGenerateGenome = new System.Windows.Forms.Button();
            this.labelFitness = new System.Windows.Forms.Label();
            this.labelGenome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16_16 = new System.Windows.Forms.Label();
            this.label15_15 = new System.Windows.Forms.Label();
            this.label14_14 = new System.Windows.Forms.Label();
            this.label13_13 = new System.Windows.Forms.Label();
            this.label12_12 = new System.Windows.Forms.Label();
            this.label11_11 = new System.Windows.Forms.Label();
            this.label10_10 = new System.Windows.Forms.Label();
            this.label9_9 = new System.Windows.Forms.Label();
            this.label8_8 = new System.Windows.Forms.Label();
            this.label7_7 = new System.Windows.Forms.Label();
            this.label6_6 = new System.Windows.Forms.Label();
            this.label5_5 = new System.Windows.Forms.Label();
            this.label4_4 = new System.Windows.Forms.Label();
            this.label3_3 = new System.Windows.Forms.Label();
            this.label2_2 = new System.Windows.Forms.Label();
            this.label1_1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStartPop = new System.Windows.Forms.NumericUpDown();
            this.labelStartingPopulation = new System.Windows.Forms.Label();
            this.timer1 = new System.Timers.Timer();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxCustomGenome = new System.Windows.Forms.TextBox();
            this.buttonCustomGenome = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBoxIterateGens = new System.Windows.Forms.CheckBox();
            this.buttonGenerateRandom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerateGenome
            // 
            this.buttonGenerateGenome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerateGenome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGenerateGenome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateGenome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateGenome.Location = new System.Drawing.Point(12, 501);
            this.buttonGenerateGenome.Name = "buttonGenerateGenome";
            this.buttonGenerateGenome.Size = new System.Drawing.Size(931, 44);
            this.buttonGenerateGenome.TabIndex = 5;
            this.buttonGenerateGenome.Text = "Start Finding Solutions";
            this.buttonGenerateGenome.UseVisualStyleBackColor = false;
            this.buttonGenerateGenome.Click += new System.EventHandler(this.buttonGenerateGenome_Click);
            // 
            // labelFitness
            // 
            this.labelFitness.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFitness.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFitness.Location = new System.Drawing.Point(12, 9);
            this.labelFitness.Name = "labelFitness";
            this.labelFitness.Size = new System.Drawing.Size(892, 23);
            this.labelFitness.TabIndex = 1;
            this.labelFitness.Text = "Press the button to find the fittest solution.";
            // 
            // labelGenome
            // 
            this.labelGenome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenome.Location = new System.Drawing.Point(12, 32);
            this.labelGenome.Name = "labelGenome";
            this.labelGenome.Size = new System.Drawing.Size(892, 23);
            this.labelGenome.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackgroundImage = global::Automatic_Color_Filler.Properties.Resources.schema2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label16_16);
            this.panel1.Controls.Add(this.label15_15);
            this.panel1.Controls.Add(this.label14_14);
            this.panel1.Controls.Add(this.label13_13);
            this.panel1.Controls.Add(this.label12_12);
            this.panel1.Controls.Add(this.label11_11);
            this.panel1.Controls.Add(this.label10_10);
            this.panel1.Controls.Add(this.label9_9);
            this.panel1.Controls.Add(this.label8_8);
            this.panel1.Controls.Add(this.label7_7);
            this.panel1.Controls.Add(this.label6_6);
            this.panel1.Controls.Add(this.label5_5);
            this.panel1.Controls.Add(this.label4_4);
            this.panel1.Controls.Add(this.label3_3);
            this.panel1.Controls.Add(this.label2_2);
            this.panel1.Controls.Add(this.label1_1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(239, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 383);
            this.panel1.TabIndex = 3;
            // 
            // label16_16
            // 
            this.label16_16.BackColor = System.Drawing.Color.Transparent;
            this.label16_16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16_16.Location = new System.Drawing.Point(367, 333);
            this.label16_16.Name = "label16_16";
            this.label16_16.Size = new System.Drawing.Size(32, 25);
            this.label16_16.TabIndex = 36;
            this.label16_16.Text = "16";
            // 
            // label15_15
            // 
            this.label15_15.BackColor = System.Drawing.Color.Transparent;
            this.label15_15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15_15.Location = new System.Drawing.Point(278, 290);
            this.label15_15.Name = "label15_15";
            this.label15_15.Size = new System.Drawing.Size(36, 23);
            this.label15_15.TabIndex = 35;
            this.label15_15.Text = "15";
            // 
            // label14_14
            // 
            this.label14_14.BackColor = System.Drawing.Color.Transparent;
            this.label14_14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14_14.Location = new System.Drawing.Point(189, 293);
            this.label14_14.Name = "label14_14";
            this.label14_14.Size = new System.Drawing.Size(31, 20);
            this.label14_14.TabIndex = 34;
            this.label14_14.Text = "14";
            // 
            // label13_13
            // 
            this.label13_13.BackColor = System.Drawing.Color.Transparent;
            this.label13_13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13_13.Location = new System.Drawing.Point(326, 251);
            this.label13_13.Name = "label13_13";
            this.label13_13.Size = new System.Drawing.Size(31, 24);
            this.label13_13.TabIndex = 33;
            this.label13_13.Text = "13";
            // 
            // label12_12
            // 
            this.label12_12.BackColor = System.Drawing.Color.Transparent;
            this.label12_12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12_12.Location = new System.Drawing.Point(229, 251);
            this.label12_12.Name = "label12_12";
            this.label12_12.Size = new System.Drawing.Size(32, 24);
            this.label12_12.TabIndex = 32;
            this.label12_12.Text = "12";
            // 
            // label11_11
            // 
            this.label11_11.BackColor = System.Drawing.Color.Transparent;
            this.label11_11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11_11.Location = new System.Drawing.Point(273, 213);
            this.label11_11.Name = "label11_11";
            this.label11_11.Size = new System.Drawing.Size(32, 32);
            this.label11_11.TabIndex = 31;
            this.label11_11.Text = "11";
            // 
            // label10_10
            // 
            this.label10_10.BackColor = System.Drawing.Color.Transparent;
            this.label10_10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10_10.Location = new System.Drawing.Point(189, 213);
            this.label10_10.Name = "label10_10";
            this.label10_10.Size = new System.Drawing.Size(31, 32);
            this.label10_10.TabIndex = 30;
            this.label10_10.Text = "10";
            // 
            // label9_9
            // 
            this.label9_9.BackColor = System.Drawing.Color.Transparent;
            this.label9_9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_9.Location = new System.Drawing.Point(132, 214);
            this.label9_9.Name = "label9_9";
            this.label9_9.Size = new System.Drawing.Size(22, 32);
            this.label9_9.TabIndex = 29;
            this.label9_9.Text = "9";
            // 
            // label8_8
            // 
            this.label8_8.BackColor = System.Drawing.Color.Transparent;
            this.label8_8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8_8.Location = new System.Drawing.Point(77, 234);
            this.label8_8.Name = "label8_8";
            this.label8_8.Size = new System.Drawing.Size(32, 28);
            this.label8_8.TabIndex = 28;
            this.label8_8.Text = "8";
            // 
            // label7_7
            // 
            this.label7_7.BackColor = System.Drawing.Color.Transparent;
            this.label7_7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_7.Location = new System.Drawing.Point(240, 156);
            this.label7_7.Name = "label7_7";
            this.label7_7.Size = new System.Drawing.Size(32, 36);
            this.label7_7.TabIndex = 27;
            this.label7_7.Text = "7";
            // 
            // label6_6
            // 
            this.label6_6.BackColor = System.Drawing.Color.Transparent;
            this.label6_6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_6.Location = new System.Drawing.Point(286, 116);
            this.label6_6.Name = "label6_6";
            this.label6_6.Size = new System.Drawing.Size(32, 36);
            this.label6_6.TabIndex = 26;
            this.label6_6.Text = "6";
            // 
            // label5_5
            // 
            this.label5_5.BackColor = System.Drawing.Color.Transparent;
            this.label5_5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_5.Location = new System.Drawing.Point(170, 116);
            this.label5_5.Name = "label5_5";
            this.label5_5.Size = new System.Drawing.Size(31, 36);
            this.label5_5.TabIndex = 25;
            this.label5_5.Text = "5";
            // 
            // label4_4
            // 
            this.label4_4.BackColor = System.Drawing.Color.Transparent;
            this.label4_4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_4.Location = new System.Drawing.Point(367, 96);
            this.label4_4.Name = "label4_4";
            this.label4_4.Size = new System.Drawing.Size(32, 36);
            this.label4_4.TabIndex = 24;
            this.label4_4.Text = "4";
            // 
            // label3_3
            // 
            this.label3_3.BackColor = System.Drawing.Color.Transparent;
            this.label3_3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_3.Location = new System.Drawing.Point(220, 63);
            this.label3_3.Name = "label3_3";
            this.label3_3.Size = new System.Drawing.Size(24, 21);
            this.label3_3.TabIndex = 23;
            this.label3_3.Text = "3";
            // 
            // label2_2
            // 
            this.label2_2.BackColor = System.Drawing.Color.Transparent;
            this.label2_2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_2.Location = new System.Drawing.Point(77, 96);
            this.label2_2.Name = "label2_2";
            this.label2_2.Size = new System.Drawing.Size(32, 36);
            this.label2_2.TabIndex = 22;
            this.label2_2.Text = "2";
            // 
            // label1_1
            // 
            this.label1_1.BackColor = System.Drawing.Color.Transparent;
            this.label1_1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_1.Location = new System.Drawing.Point(240, 23);
            this.label1_1.Name = "label1_1";
            this.label1_1.Size = new System.Drawing.Size(21, 24);
            this.label1_1.TabIndex = 21;
            this.label1_1.Text = "1";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(207, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 75);
            this.label7.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(244, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 96);
            this.label6.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 96);
            this.label5.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(240, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 57);
            this.label11.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(170, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 57);
            this.label10.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(269, 323);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(209, 40);
            this.label16.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(240, 285);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 38);
            this.label15.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(152, 285);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 38);
            this.label14.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(207, 247);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 43);
            this.label12.TabIndex = 12;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 95);
            this.label13.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 95);
            this.label9.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 133);
            this.label8.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 134);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 38);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 307);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 306);
            this.label1.TabIndex = 0;
            // 
            // numericUpDownStartPop
            // 
            this.numericUpDownStartPop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownStartPop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownStartPop.Location = new System.Drawing.Point(12, 358);
            this.numericUpDownStartPop.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            this.numericUpDownStartPop.Name = "numericUpDownStartPop";
            this.numericUpDownStartPop.Size = new System.Drawing.Size(54, 26);
            this.numericUpDownStartPop.TabIndex = 2;
            this.numericUpDownStartPop.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // labelStartingPopulation
            // 
            this.labelStartingPopulation.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelStartingPopulation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingPopulation.Location = new System.Drawing.Point(12, 332);
            this.labelStartingPopulation.Name = "labelStartingPopulation";
            this.labelStartingPopulation.Size = new System.Drawing.Size(189, 23);
            this.labelStartingPopulation.TabIndex = 5;
            this.labelStartingPopulation.Text = "Starting Population:";
            // 
            // timer1
            // 
            this.timer1.Interval = 500D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(189, 23);
            this.label17.TabIndex = 6;
            this.label17.Text = "Timer Interval:";
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownInterval.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownInterval.Location = new System.Drawing.Point(12, 278);
            this.numericUpDownInterval.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numericUpDownInterval.Minimum = new decimal(new int[] { 500, 0, 0, 0 });
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(99, 26);
            this.numericUpDownInterval.TabIndex = 1;
            this.numericUpDownInterval.Value = new decimal(new int[] { 500, 0, 0, 0 });
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(117, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 23);
            this.label18.TabIndex = 8;
            this.label18.Text = "ms";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(72, 361);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 23);
            this.label19.TabIndex = 9;
            this.label19.Text = "Genomes";
            // 
            // textBoxCustomGenome
            // 
            this.textBoxCustomGenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCustomGenome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCustomGenome.Location = new System.Drawing.Point(12, 460);
            this.textBoxCustomGenome.MaxLength = 32;
            this.textBoxCustomGenome.Name = "textBoxCustomGenome";
            this.textBoxCustomGenome.Size = new System.Drawing.Size(356, 25);
            this.textBoxCustomGenome.TabIndex = 3;
            // 
            // buttonCustomGenome
            // 
            this.buttonCustomGenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCustomGenome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonCustomGenome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCustomGenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCustomGenome.Location = new System.Drawing.Point(506, 461);
            this.buttonCustomGenome.Name = "buttonCustomGenome";
            this.buttonCustomGenome.Size = new System.Drawing.Size(126, 25);
            this.buttonCustomGenome.TabIndex = 4;
            this.buttonCustomGenome.Text = "Calculate Fitness";
            this.buttonCustomGenome.UseVisualStyleBackColor = false;
            this.buttonCustomGenome.Click += new System.EventHandler(this.buttonCustomGenome_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label20.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(12, 439);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(189, 18);
            this.label20.TabIndex = 12;
            this.label20.Text = "Fitness of custom genome";
            // 
            // checkBoxIterateGens
            // 
            this.checkBoxIterateGens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxIterateGens.Checked = true;
            this.checkBoxIterateGens.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIterateGens.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxIterateGens.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIterateGens.Location = new System.Drawing.Point(651, 461);
            this.checkBoxIterateGens.Name = "checkBoxIterateGens";
            this.checkBoxIterateGens.Size = new System.Drawing.Size(275, 24);
            this.checkBoxIterateGens.TabIndex = 13;
            this.checkBoxIterateGens.Text = "Iterate Through Generations";
            this.checkBoxIterateGens.UseVisualStyleBackColor = true;
            // 
            // buttonGenerateRandom
            // 
            this.buttonGenerateRandom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonGenerateRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonGenerateRandom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonGenerateRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateRandom.Location = new System.Drawing.Point(374, 461);
            this.buttonGenerateRandom.Name = "buttonGenerateRandom";
            this.buttonGenerateRandom.Size = new System.Drawing.Size(126, 25);
            this.buttonGenerateRandom.TabIndex = 14;
            this.buttonGenerateRandom.Text = "Generate Random";
            this.buttonGenerateRandom.UseVisualStyleBackColor = false;
            this.buttonGenerateRandom.Click += new System.EventHandler(this.buttonGenerateRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 557);
            this.Controls.Add(this.buttonGenerateRandom);
            this.Controls.Add(this.checkBoxIterateGens);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonCustomGenome);
            this.Controls.Add(this.textBoxCustomGenome);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.numericUpDownInterval);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.labelStartingPopulation);
            this.Controls.Add(this.numericUpDownStartPop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelGenome);
            this.Controls.Add(this.labelFitness);
            this.Controls.Add(this.buttonGenerateGenome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Constraint Satisfaction Problem Solver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartPop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonGenerateRandom;

        private System.Windows.Forms.CheckBox checkBoxIterateGens;

        private System.Windows.Forms.Label label1_1;
        private System.Windows.Forms.Label label2_2;
        private System.Windows.Forms.Label label3_3;
        private System.Windows.Forms.Label label4_4;
        private System.Windows.Forms.Label label5_5;
        private System.Windows.Forms.Label label6_6;
        private System.Windows.Forms.Label label7_7;
        private System.Windows.Forms.Label label8_8;
        private System.Windows.Forms.Label label9_9;
        private System.Windows.Forms.Label label10_10;
        private System.Windows.Forms.Label label11_11;
        private System.Windows.Forms.Label label12_12;
        private System.Windows.Forms.Label label13_13;
        private System.Windows.Forms.Label label14_14;
        private System.Windows.Forms.Label label15_15;
        private System.Windows.Forms.Label label16_16;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label20;

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxCustomGenome;
        private System.Windows.Forms.Button buttonCustomGenome;

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label18;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.Label labelStartingPopulation;

        private System.Windows.Forms.NumericUpDown numericUpDownStartPop;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label labelGenome;

        private System.Windows.Forms.Button buttonGenerateGenome;
        private System.Windows.Forms.Label labelFitness;

        #endregion
    }
}