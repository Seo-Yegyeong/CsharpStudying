using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//생각 후 코딩 :D

namespace CsharpStudying
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            int stCount;
            bool isParsed = int.TryParse(textBox_input.Text, out stCount);
            textBox_result.Text = ""; //initialize

            if (!isParsed) //error catch
            {
                MessageBox.Show("Please put a number");
            }
            else
            {
                Random r = new Random();
                int[] stScore = new int[stCount];
                string[] stName = new string[stCount];
                for (int i = 0; i < stCount; i++)
                {
                    stName[i] = "학생" + (i+1).ToString();
                    stScore[i] = r.Next(0, 101);
                    textBox_result.Text += printScore(stName[i], stScore[i]);
                }
            }
        }

        string printScore(string name, int score)
        {
            return name + "의 점수: " + score + "점\r\n";
        }
    }
}