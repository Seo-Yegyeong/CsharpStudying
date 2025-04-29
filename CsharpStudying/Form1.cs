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
            int[] array = Add(30, 6);
            textBox1.Text = String.Join(", ", array);
        }

        int[] Add(int x, int y)
        {
            int[] array = new int[2];
            array[0] = x / y;
            array[1] = x % y;
            return array;
        }
    }
}