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
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1;  j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }
        }
    }
}