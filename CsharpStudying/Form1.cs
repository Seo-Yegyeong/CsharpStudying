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
        enum RPS
        {
            Rock,
            Paper,
            Scissors
        }

        enum Result
        {
            Win,
            Lose,
            Same
        }

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
                    Console.WriteLine(i + "\r\n");
                }
            }
            Console.WriteLine("cnt: " + cnt + " sum: " + sum);
        }

        //Result MatchResult(RPS hand)
        //{
        //    Random
        //}

        private void buttonScissors_Click(object sender, EventArgs e)
        {

        }

        private void buttonRock_Click(object sender, EventArgs e)
        {

        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {

        }



        //RPS CheckRPS(string hand)
        //{
        //    switch (hand)
        //    {
        //        case "가위":
        //            return RPS.Scissors;
        //        case "바위":
        //            return RPS.Rock;
        //        case "보":
        //            return
        //    }
        //}
    }
}