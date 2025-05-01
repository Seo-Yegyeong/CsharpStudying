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
        // 가위 / 바위 / 보
        enum RPS
        {
            Rock,
            Paper,
            Scissors,
            fail = 100
        }

        // 승부 결과 (승리 / 패배 / 비김)
        enum Result
        {
            Win,
            Lose,
            Same
        }

        public Form1()
        {
            InitializeComponent();

        }

        // (가위, 바위, 보) 버튼 클릭 시 실행 로직
        private void RPS_Click(object sender, EventArgs e)
        {
            //get rid of pre-records.
            textBox_result.Text = "";

            //What button did the user click?
            RPS mine = CheckRPS(((Button)sender).Name);
            if (mine == RPS.fail) //validation
            {
                MessageBox.Show("fail!"); return;
            }

            //create computer's random option
            Random random = new Random();
            int num = random.Next(0, 3);
            RPS computer = CheckRPS(num);

            //Get the result of 'Rock-Paper-Scissors'
            MatchResult(mine, computer);
        }

        // 승부 판단 로직
        void MatchResult(RPS mine, RPS computer)
        {
            Result result;
            if (mine == computer)
            {
                textBox_result.Text += "비겼습니다!\r\n";
                result = Result.Same;
            }
            else if ((mine == RPS.Rock && computer == RPS.Scissors) || (mine == RPS.Paper && computer == RPS.Rock) || (mine == RPS.Scissors && computer == RPS.Paper))
            {

                textBox_result.Text += "이겼어요 야호~~!\r\n";
                result = Result.Win;
            }
            else
            {
                textBox_result.Text += "마왕의 득점! 내가 봐줬다~~\r\n";
                result = Result.Lose;
            }
            ControlScore(result);
        }

        // 점수 관리 로직
        void ControlScore(Result result)
        {
            bool isParsed;
            int score = 0;
            if (result == Result.Win)
            {
                isParsed = int.TryParse(textBox_myScore.Text, out score);
                if (isParsed)
                {
                    textBox_myScore.Text = (++score).ToString();
                }
            }
            else if (result == Result.Lose)
            {
                isParsed = int.TryParse(textBox_computerScore.Text, out score);
                if (isParsed)
                {
                    textBox_computerScore.Text = (++score).ToString();
                }
            }
            
            if (score == 3)
            {
                textBox_result.Text += "게임 끝!";
                SetToZero();
            }
        }

        // 점수 초기화 로직
        void SetToZero()
        {
            textBox_myScore.Text = "0";
            textBox_computerScore.Text = "0";
        }

        
        // User가 선택한 옵션값을 ENUM 값으로 반환
        RPS CheckRPS(string mine)
        {
            switch (mine)
            {
                case "buttonScissors":
                    return RPS.Scissors;
                case "buttonRock":
                    return RPS.Rock;
                case "buttonPaper":
                    return RPS.Paper;
                default:
                    return RPS.fail;
            }
        }

        // Computer가 랜덤 생성한 옵션값을 ENUM 값으로 반환
        RPS CheckRPS(int computer)
        {
            switch (computer)
            {
                case 0:
                    textBox_result.Text += "마왕의 선택: Scissors\r\n";
                    return RPS.Scissors;
                case 1:
                    textBox_result.Text += "마왕의 선택: Rock\r\n";
                    return RPS.Rock;
                case 2:
                    textBox_result.Text += "마왕의 선택: Paper\r\n";
                    return RPS.Paper;
                default:
                    return RPS.fail;
            }
        }
    }
}