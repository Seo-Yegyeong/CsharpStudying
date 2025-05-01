namespace CsharpStudying
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_myScore = new System.Windows.Forms.TextBox();
            this.textBox_computerScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(12, 12);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(419, 174);
            this.textBox_result.TabIndex = 2;
            // 
            // buttonScissors
            // 
            this.buttonScissors.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonScissors.Location = new System.Drawing.Point(12, 276);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(120, 80);
            this.buttonScissors.TabIndex = 3;
            this.buttonScissors.Text = "가위";
            this.buttonScissors.UseVisualStyleBackColor = true;
            this.buttonScissors.Click += new System.EventHandler(this.RPS_Click);
            // 
            // buttonRock
            // 
            this.buttonRock.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonRock.Location = new System.Drawing.Point(160, 276);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(120, 80);
            this.buttonRock.TabIndex = 4;
            this.buttonRock.Text = "바위";
            this.buttonRock.UseVisualStyleBackColor = true;
            this.buttonRock.Click += new System.EventHandler(this.RPS_Click);
            // 
            // buttonPaper
            // 
            this.buttonPaper.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPaper.Location = new System.Drawing.Point(311, 276);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(120, 80);
            this.buttonPaper.TabIndex = 5;
            this.buttonPaper.Text = "보";
            this.buttonPaper.UseVisualStyleBackColor = true;
            this.buttonPaper.Click += new System.EventHandler(this.RPS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "용사";
            // 
            // textBox_myScore
            // 
            this.textBox_myScore.Location = new System.Drawing.Point(23, 223);
            this.textBox_myScore.Multiline = true;
            this.textBox_myScore.Name = "textBox_myScore";
            this.textBox_myScore.Size = new System.Drawing.Size(100, 30);
            this.textBox_myScore.TabIndex = 7;
            this.textBox_myScore.Text = "0";
            this.textBox_myScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_computerScore
            // 
            this.textBox_computerScore.Location = new System.Drawing.Point(321, 223);
            this.textBox_computerScore.Multiline = true;
            this.textBox_computerScore.Name = "textBox_computerScore";
            this.textBox_computerScore.Size = new System.Drawing.Size(100, 30);
            this.textBox_computerScore.TabIndex = 9;
            this.textBox_computerScore.Text = "0";
            this.textBox_computerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "마왕";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(442, 367);
            this.Controls.Add(this.textBox_computerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_myScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_myScore;
        private System.Windows.Forms.TextBox textBox_computerScore;
        private System.Windows.Forms.Label label2;
    }
}

