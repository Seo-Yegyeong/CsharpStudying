using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpStudying
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (coin(true) == true)
            {
                textBox1.Text = "승리";
            }
            else
            {
                textBox1.Text = "패배";
            }
        }

        bool coin(bool coinTF)
        {
            Random random = new Random();
            bool result;
            if (random.Next(0, 100) % 2 == 1)
            {
                result = true;
            }
            else {
                result = false;
            }

            if (result == coinTF)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}