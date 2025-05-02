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

        int userScore = 0;
        int comScore = 0;


        public Form1()
        {
            InitializeComponent();

        }

        // (가위, 바위, 보) 버튼 클릭 시 실행 로직
        private void RPS_Click(object sender, EventArgs e)
        {
            textBox_result.Text = ""; //get rid of pre-records.
            RPS mine = CheckRPS(((Button)sender).Name); //What button did the user click?
            PlayRPSGrame(mine); //Get the result of 'Rock-Paper-Scissors'
        }

        // 게임 전체 로직
        void PlayRPSGrame(RPS mine)
        {
            Result result = RPSGame(mine);
            if (result == Result.Win)
            {
                userScore++;
                textBox_myScore.Text = userScore.ToString();
            }
            else if (result == Result.Lose)
            {
                comScore++;
                textBox_comScore.Text = comScore.ToString();
            }

            if (userScore == 3 || comScore == 3)
            {
                textBox_result.Text += "게임 끝!";
                SetToZero();
            }
        }

        // 승부 판단 로직
        Result RPSGame(RPS mine)
        {
            Random r = new Random();
            RPS computer = (RPS)r.Next(0, 3);
            
            textBox_result.Text += $"마왕의 선택: {computer}\r\n";
            if (mine == computer)
            {
                textBox_result.Text += "비겼습니다!\r\n";
                return Result.Same;
            }
            else if ((mine == RPS.Rock && computer == RPS.Scissors) || (mine == RPS.Paper && computer == RPS.Rock) || (mine == RPS.Scissors && computer == RPS.Paper))
            {

                textBox_result.Text += "이겼어요 야호~~!\r\n";
                return Result.Win;
            }
            else
            {
                textBox_result.Text += "마왕의 득점! 내가 봐줬다~~\r\n";
                return Result.Lose;
            }
        }

        // 점수 초기화 로직
        void SetToZero()
        {
            textBox_myScore.Text = "0";
            textBox_comScore.Text = "0";
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
    }
}