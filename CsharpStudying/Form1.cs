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
            int cnt = 0;
            int sum = 0;

            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0 && i % 5 != 0)
                {
                    cnt++;
                    sum += i;
                }
            }
            Console.WriteLine("cnt: " + cnt + " sum: " + sum);
        }
    }
}