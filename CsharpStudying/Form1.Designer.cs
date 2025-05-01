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
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.button_input = new System.Windows.Forms.Button();
            this.buttonScissors = new System.Windows.Forms.Button();
            this.buttonRock = new System.Windows.Forms.Button();
            this.buttonPaper = new System.Windows.Forms.Button();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(35, 23);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(105, 41);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(35, 178);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(454, 140);
            this.textBox_result.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_input.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_input.Location = new System.Drawing.Point(274, 23);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(66, 41);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Click";
            this.button_input.UseVisualStyleBackColor = false;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // buttonScissors
            // 
            this.buttonScissors.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonScissors.Location = new System.Drawing.Point(35, 102);
            this.buttonScissors.Name = "buttonScissors";
            this.buttonScissors.Size = new System.Drawing.Size(66, 41);
            this.buttonScissors.TabIndex = 3;
            this.buttonScissors.Text = "가위";
            this.buttonScissors.UseVisualStyleBackColor = true;
            // 
            // buttonRock
            // 
            this.buttonRock.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonRock.Location = new System.Drawing.Point(127, 102);
            this.buttonRock.Name = "buttonRock";
            this.buttonRock.Size = new System.Drawing.Size(66, 41);
            this.buttonRock.TabIndex = 4;
            this.buttonRock.Text = "바위";
            this.buttonRock.UseVisualStyleBackColor = true;
            // 
            // buttonPaper
            // 
            this.buttonPaper.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonPaper.Location = new System.Drawing.Point(219, 102);
            this.buttonPaper.Name = "buttonPaper";
            this.buttonPaper.Size = new System.Drawing.Size(66, 41);
            this.buttonPaper.TabIndex = 5;
            this.buttonPaper.Text = "보";
            this.buttonPaper.UseVisualStyleBackColor = true;
            // 
            // textBox_score
            // 
            this.textBox_score.Location = new System.Drawing.Point(151, 23);
            this.textBox_score.Multiline = true;
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(105, 41);
            this.textBox_score.TabIndex = 6;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(527, 367);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.buttonPaper);
            this.Controls.Add(this.buttonRock);
            this.Controls.Add(this.buttonScissors);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.textBox_input);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.Button buttonScissors;
        private System.Windows.Forms.Button buttonRock;
        private System.Windows.Forms.Button buttonPaper;
        private System.Windows.Forms.TextBox textBox_score;
    }
}

