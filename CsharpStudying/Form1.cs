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
        enum Week
        {
            Sunday, //0
            Monday, //1
            Tuesday, //2
            Wednesday, //3
            Thursday, //4
            Friday, //5
            Saturday, //6
            Error = 999
        };

        Week week;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_input_Click(object sender, EventArgs e)
        {
            string msg = string.Empty;
            switch (textBox_input.Text)
            {
                case "Sunday":
                    msg = "예헹 행복한 날이여";
                    break;
                case "Monday":
                    msg = "월요일 좋아~ 너무도 좋아 ^^ - 스폰지밥";
                    break;
                case "Tuesday":
                    msg = "자 달려볼까유~ 오늘도 열시미";
                    break;
                case "Wednesday":
                    msg = "벌써 주중의 중간! 뭔가 특별한 날인 듯한 느낌 ㅎㅎ";
                    break;
                case "Thursday":
                    msg = "뻔하지만 오늘도 열심히 ㅋㅋ!! 잘하고 이따";
                    break;
                case "Friday":
                    msg = "이제 주말이고만~~~ 주말엔 어떻게 보내볼까?!";
                    break;
                case "Saturday":
                    msg = "뒹굴뒹굴, 햇살도 쫌 쬐고, 누려보자~!";
                    break;
                default:
                    msg = "잘못 입력했어요 :( 다시 입력해주세요!";
                    break;
            }
            textBox_result.Text = msg;
        }
    }
}