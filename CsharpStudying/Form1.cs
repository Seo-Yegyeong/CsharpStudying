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
        private string boolValue;

        public Form1()
        {

            InitializeComponent();
            
            //string[,] order = new string[3, 4]
            //{
            //    {"홍길동", "포도", "복숭아", "바나나"},
            //    {"아무개", "사과", "수박", "오렌지"},
            //    {"손오공", "바나나", "사과", "오렌지"}
            //};

            //char[] tmp = new char[3];
            //int i = 0;
            //string result = "";
            //foreach (string item in order)
            //{
            //    if (i % 4 == 0)
            //    {
            //        result += item + ": ";
            //    }
            //    else
            //    {
            //        if (item == "바나나")
            //        {
            //            //order[i] = "바나나 (유기농)";
            //        }
            //    }
            //    i++;
            //}
            //textBox1.Text = result;


        }

        bool Coin(bool coinTF)
        {
            Random random = new Random();
            int result = random.Next(0, 100) % 2;
            if ((result == 1 && coinTF == true) || (result == 0 && coinTF == false))
            {
                return true;
            }
            return false;
        }
        private void button_input_Click(object sender, EventArgs e)
        {
            #region #Debugging Test
            Console.WriteLine("textBox : " + textBox_input.Text + "radioButton : " + boolValue);
            Console.WriteLine("textBox : " + (textBox_input.Text == "") + " radioButton : " + (boolValue==null));
            #endregion

            if (textBox_input.Text == "" || this.boolValue == null)
            {
                textBox_result.Text = "You didn't pick any option!";
                return;
            }
            else if (textBox_input.Text != "true" && textBox_input.Text != "false")
            {
                textBox_result.Text = "invalid value!";
                return;
            }

            if (textBox_input.Text != "")
            {
                boolValue = textBox_input.Text;
            }

            textBox_result.Text = Coin(Convert.ToBoolean(boolValue)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boolValue = "true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boolValue = "false";
        }
    }
}