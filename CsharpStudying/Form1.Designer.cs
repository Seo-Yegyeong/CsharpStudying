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
            this.SuspendLayout();
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(36, 51);
            this.textBox_input.Multiline = true;
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(220, 51);
            this.textBox_input.TabIndex = 0;
            // 
            // textBox_result
            // 
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(34, 141);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(454, 140);
            this.textBox_result.TabIndex = 2;
            // 
            // button_input
            // 
            this.button_input.Font = new System.Drawing.Font("GulimChe", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_input.Location = new System.Drawing.Point(274, 51);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(75, 51);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(527, 367);
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
    }
}

