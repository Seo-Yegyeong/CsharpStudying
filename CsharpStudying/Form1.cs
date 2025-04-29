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

            string[] results = new string[10];

            results[0] = "동해 물과 백두산이".IndexOf("백두산").ToString();
            results[1] = "토요일에 먹는 토마토".LastIndexOf("토").ToString();
            results[2] = "질서 있는 퇴장".Contains("퇴").ToString();
            results[3] = "그 사람의 그림자는 그랬다.".Replace("그", "이");
            results[4] = "삼성 갤럭시".Insert(2, "애플");
            results[5] = "오늘은 왠지 더 배고프다".Remove("오늘은 왠지 더 배고프다".IndexOf("더"), 1);
            string[] splitedData = "이름, 나이, 전화번호".Split(',');
            results[6] = splitedData[0];
            results[7] = splitedData[1].Trim();
            results[8] = splitedData[2].Trim();
            results[9] = "우리 나라 만세".Substring(3, 2);

            foreach (string s in results) {
                textBox1.Text += s + "\r\n";
            }
        }
    }
}