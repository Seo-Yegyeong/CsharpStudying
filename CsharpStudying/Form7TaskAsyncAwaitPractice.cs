using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpStudying
{
    public partial class Form7TaskAsyncAwaitPractice : Form
    {
        public Form7TaskAsyncAwaitPractice()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = string.Empty;

            openFileDialog.InitialDirectory = "C:\\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                var fileStream = openFileDialog.OpenFile();

                ReadFileAsync(filePath);
            }            
        }
        private async Task ReadFileAsync(string filePath)
        {
            StreamReader sr = File.OpenText(filePath);
            string fileContent = string.Empty;
            
            textBox1.Text = await sr.ReadToEndAsync();
            
            Console.WriteLine("The end of program!");
            sr.Close();
        }
    }
}
