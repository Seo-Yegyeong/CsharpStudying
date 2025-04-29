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

            string text = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다. -공자";
            int[] idxList = new int[3];
            string[] stringList = { ".", "-" };

            // 1-1
            // Record the location of special characters
            for (int i = 0; i < stringList.Length; i++)
            {
                idxList[i] = text.IndexOf(stringList[i]);
            }
            // Remove the "-공자" part
            text = text.Remove(idxList[1], 3);
            Console.WriteLine("++++++" + text);
            textBox1.Text = text + "\r\n";
            
            //----------------------------------------------
            //1-2
            string[] wordList = new string[3];
            wordList[0] = text.Substring(text.IndexOf("얼마나"), 3);
            wordList[1] = text.Substring(text.IndexOf("천천히"), 3);
            wordList[2] = text.Substring(text.IndexOf("가는지"), 3);
            textBox1.Text += string.Join(" ", wordList) + "\r\n";

            //----------------------------------------------
            //1-3
            text = text.Remove(idxList[0],1);
            string[] tempList = text.Split(' ');
            textBox1.Text += string.Join(",", tempList);
        }
    }
}