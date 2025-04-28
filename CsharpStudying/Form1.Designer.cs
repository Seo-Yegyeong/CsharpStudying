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
            this.textBox_print = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_print = new System.Windows.Forms.TextBox();
            this.textBox2_print = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_print
            // 
            this.textBox_print.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox_print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_print.Font = new System.Drawing.Font("NanumGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_print.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox_print.HideSelection = false;
            this.textBox_print.Location = new System.Drawing.Point(42, 78);
            this.textBox_print.Multiline = true;
            this.textBox_print.Name = "textBox_print";
            this.textBox_print.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_print.Size = new System.Drawing.Size(500, 103);
            this.textBox_print.TabIndex = 0;
            this.textBox_print.Text = "0";
            this.textBox_print.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Result:\r\n";
            // 
            // textBox1_print
            // 
            this.textBox1_print.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1_print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_print.Font = new System.Drawing.Font("NanumGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1_print.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1_print.HideSelection = false;
            this.textBox1_print.Location = new System.Drawing.Point(42, 211);
            this.textBox1_print.Multiline = true;
            this.textBox1_print.Name = "textBox1_print";
            this.textBox1_print.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1_print.Size = new System.Drawing.Size(500, 103);
            this.textBox1_print.TabIndex = 2;
            this.textBox1_print.Text = "0";
            this.textBox1_print.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2_print
            // 
            this.textBox2_print.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2_print.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2_print.Font = new System.Drawing.Font("NanumGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2_print.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2_print.HideSelection = false;
            this.textBox2_print.Location = new System.Drawing.Point(42, 342);
            this.textBox2_print.Multiline = true;
            this.textBox2_print.Name = "textBox2_print";
            this.textBox2_print.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2_print.Size = new System.Drawing.Size(500, 103);
            this.textBox2_print.TabIndex = 3;
            this.textBox2_print.Text = "0";
            this.textBox2_print.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2_print);
            this.Controls.Add(this.textBox1_print);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_print);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_print;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_print;
        private System.Windows.Forms.TextBox textBox2_print;
    }
}

