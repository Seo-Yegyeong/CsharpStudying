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

            string[] array = new string[10]{
                "푸르른 공기가 나를 사무친다 가득",
                "하늘을 날을 수 있을 듯한 밤이다",
                "잔요동이 헤엄쳐 오는 곳이 어딘지 몰라 안 가는 건 아니야",
                "따사로운 온기가 닿을 구름을 향하는 비행이 망설여지기도 하겠지만",
                "한 번뿐인 이 모험을 겁내진 않아",
                "오늘보다 오래된 날은 없으니 어서 날아오르자",
                "제목: 청춘만화, 작사-작곡: 이무진, 연도: 2025",
                "분명한 건 지금보다 환하게 빛날 거야 아직 서막일 뿐야",
                "푸르른 공기가 날 사무쳐 안아 하늘을 날을 수 있을 듯한 밤이다",
                "잔요동이 헤엄쳐 오는 곳으로 가자\r\n이 세상에서 제일 높은 곳을 향해서\r\n뛰어오르자"
            };

            textBox1.Text = "IndexOf(\"푸르른 공기\"): " + array[0].IndexOf("푸르른 공기").ToString() + "\r\n";
            textBox1.Text += "LastIndexOf(\"을\"): " + array[1].LastIndexOf("을") + "\r\n";
            textBox1.Text += "Contains(\"몰\")" + array[2].Contains("몰") + "\r\n";
            textBox1.Text += "Replace(\"비행\", \"이륙\"): " + array[3].Replace("비행", "이륙") + "\r\n";
            textBox1.Text += "Insert(10, \"과 도전\"): " + array[4].Insert(10, "과 도전") + "\r\n";
            textBox1.Text += "Remove(16, 3): " + array[5].Remove(16, 3) + "\r\n";
            textBox1.Text += "Split(','):\r\n"
                                + array[6].Split(',')[0] + "\r\n"
                                + array[6].Split(',')[1] + "\r\n"
                                + array[6].Split(',')[2] + "\r\n";
            textBox1.Text += "Substring(11, 3): " + array[7].Substring(11, 3) + "\r\n";

        }
    }
}