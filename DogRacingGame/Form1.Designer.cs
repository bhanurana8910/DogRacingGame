﻿
namespace DogRacingGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.linalbl = new System.Windows.Forms.Label();
            this.rocklbl = new System.Windows.Forms.Label();
            this.thorlbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Button();
            this.dogNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.NameOfBettorLabel = new System.Windows.Forms.Label();
            this.linaradio = new System.Windows.Forms.RadioButton();
            this.rockradio = new System.Windows.Forms.RadioButton();
            this.thorradio = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.linalbl);
            this.groupBox1.Controls.Add(this.rocklbl);
            this.groupBox1.Controls.Add(this.thorlbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Race);
            this.groupBox1.Controls.Add(this.dogNumberNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betNumeric);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.NameOfBettorLabel);
            this.groupBox1.Controls.Add(this.linaradio);
            this.groupBox1.Controls.Add(this.rockradio);
            this.groupBox1.Controls.Add(this.thorradio);
            this.groupBox1.Controls.Add(this.MinimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(5, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(618, 130);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset Position!";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // linalbl
            // 
            this.linalbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.linalbl.Location = new System.Drawing.Point(542, 77);
            this.linalbl.Name = "linalbl";
            this.linalbl.Size = new System.Drawing.Size(244, 20);
            this.linalbl.TabIndex = 13;
            this.linalbl.Text = "Lina\'s Bet";
            this.linalbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rocklbl
            // 
            this.rocklbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rocklbl.Location = new System.Drawing.Point(542, 52);
            this.rocklbl.Name = "rocklbl";
            this.rocklbl.Size = new System.Drawing.Size(244, 20);
            this.rocklbl.TabIndex = 12;
            this.rocklbl.Text = "Rock\'s Bet";
            this.rocklbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thorlbl
            // 
            this.thorlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thorlbl.Location = new System.Drawing.Point(542, 27);
            this.thorlbl.Name = "thorlbl";
            this.thorlbl.Size = new System.Drawing.Size(244, 20);
            this.thorlbl.TabIndex = 11;
            this.thorlbl.Text = "Thor\'s Bet";
            this.thorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(539, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets";
            // 
            // Race
            // 
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.Location = new System.Drawing.Point(699, 123);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(87, 30);
            this.Race.TabIndex = 9;
            this.Race.Text = "Race!";
            this.Race.UseVisualStyleBackColor = true;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // dogNumberNumeric
            // 
            this.dogNumberNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dogNumberNumeric.Location = new System.Drawing.Point(349, 126);
            this.dogNumberNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberNumeric.Name = "dogNumberNumeric";
            this.dogNumberNumeric.Size = new System.Drawing.Size(54, 20);
            this.dogNumberNumeric.TabIndex = 8;
            this.dogNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 133);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "bucks on dog number";
            // 
            // betNumeric
            // 
            this.betNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.betNumeric.Location = new System.Drawing.Point(173, 126);
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(54, 20);
            this.betNumeric.TabIndex = 6;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumeric.ValueChanged += new System.EventHandler(this.betNumeric_ValueChanged);
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(92, 123);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(75, 23);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // NameOfBettorLabel
            // 
            this.NameOfBettorLabel.AutoSize = true;
            this.NameOfBettorLabel.Location = new System.Drawing.Point(7, 128);
            this.NameOfBettorLabel.Name = "NameOfBettorLabel";
            this.NameOfBettorLabel.Size = new System.Drawing.Size(79, 13);
            this.NameOfBettorLabel.TabIndex = 4;
            this.NameOfBettorLabel.Text = "Who\'s Betting?";
            // 
            // linaradio
            // 
            this.linaradio.AutoSize = true;
            this.linaradio.Location = new System.Drawing.Point(10, 89);
            this.linaradio.Name = "linaradio";
            this.linaradio.Size = new System.Drawing.Size(45, 17);
            this.linaradio.TabIndex = 3;
            this.linaradio.TabStop = true;
            this.linaradio.Text = "Lina";
            this.linaradio.UseVisualStyleBackColor = true;
            this.linaradio.CheckedChanged += new System.EventHandler(this.radioClicked);
            // 
            // rockradio
            // 
            this.rockradio.AutoSize = true;
            this.rockradio.Location = new System.Drawing.Point(10, 66);
            this.rockradio.Name = "rockradio";
            this.rockradio.Size = new System.Drawing.Size(51, 17);
            this.rockradio.TabIndex = 2;
            this.rockradio.TabStop = true;
            this.rockradio.Text = "Rock";
            this.rockradio.UseVisualStyleBackColor = true;
            this.rockradio.CheckedChanged += new System.EventHandler(this.radioClicked);
            // 
            // thorradio
            // 
            this.thorradio.AutoSize = true;
            this.thorradio.Location = new System.Drawing.Point(10, 43);
            this.thorradio.Name = "thorradio";
            this.thorradio.Size = new System.Drawing.Size(47, 17);
            this.thorradio.TabIndex = 1;
            this.thorradio.TabStop = true;
            this.thorradio.Text = "Thor";
            this.thorradio.UseVisualStyleBackColor = true;
            this.thorradio.CheckedChanged += new System.EventHandler(this.radioClicked);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumBetLabel.Location = new System.Drawing.Point(6, 16);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(120, 24);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "Minimum Bet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(106, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(115, 191);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(76, 23);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog4.TabIndex = 9;
            this.Dog4.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(115, 141);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(76, 23);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog3.TabIndex = 8;
            this.Dog3.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(115, 87);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(76, 23);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog2.TabIndex = 7;
            this.Dog2.TabStop = false;
            // 
            // Dog1
            // 
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(115, 41);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(76, 23);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog1.TabIndex = 6;
            this.Dog1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(107, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(629, 10);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(106, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(629, 10);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(106, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(629, 10);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(106, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(629, 10);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(106, 211);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(629, 10);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label linalbl;
        private System.Windows.Forms.Label rocklbl;
        private System.Windows.Forms.Label thorlbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.NumericUpDown dogNumberNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.Label NameOfBettorLabel;
        private System.Windows.Forms.RadioButton linaradio;
        private System.Windows.Forms.RadioButton rockradio;
        private System.Windows.Forms.RadioButton thorradio;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

