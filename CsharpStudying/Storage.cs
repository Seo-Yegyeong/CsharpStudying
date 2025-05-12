/* 
 * [기본 구조 파악]
 * using 키워드 : '네임스페이스' 가져온다는 의미.
 * namespace : 여러 클래스를 논리적으로 묶은 공간.
*/

using System; // 가장 기본적인 .NET namespace (Console, Math 등 자주 쓰이는 클래스가 포함돼있음.)
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text; // 문자열과 관련된 기능을 제공하는 namespace
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpStudying // 프로젝트 이름.
{
    struct Point
    {
        public int x;
        internal int y; // internal (접근제한자) - 같은 프로젝트 안에서만 접근 가능.
        public int z;

        public static double Diff_xy(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
        }
    }

    struct Student
    {
        private string name;
        private int age;
        private double score;

        public Student(string name, int age, double score)
        {
            this.name = name;
            this.age = age;
            this.score = score;
        }
        public static void printStudent(Student s)
        {
            Console.WriteLine($"학생 {s.name}({s.age})의 성적 : {s.score}");
        }
    }


    public partial class Storage : Form
    // Form1 이라는 이름의 클래스. Form 클래스를 상속받음.
    // .NET에서 제공하는 기본 윈도우 창인 Form 클래스를 상속 받아서, 윈도우 창의 기본 동작과 속성을 물려받음.
    // partial : 이 클래스는 코드가 여러 파일로 나눠져 있음을 의미.
    {
        enum Food
        {
            None,
            Pizza,
            Burger,
            Pasta,
            Kimchi = 100 //값 지정 가능!
        };

        enum Week
        {
            none, //0
            Sunday, //1
            Monday, //2
            Tuesday, //3
            Wednesday, //4
            Thursday, //5
            Friday, //6
            Saturday, //7
            Error = 999
        };

        Week week;

        enum CoffeeMenu
        {
            Plain,
            WithMilk,
            WithIceCream
        }

        public Storage() // Form1 클래스의 생성자 (constructor)
        {
            InitializeComponent(); // Form에 포함된 UI 요소들을 초기화하는 메서드 호출. 버튼, 텍스트박스 등 디자인 도구에서 만든 컨트롤들을 실제로 생성하고 속성 설정하는 코드들이 있음. Form 실행될 때 꼭 호출되어야 윈도우 폼이 제대로 보인다!
            //executeProgram();

            // #region이란? 특정 코드 블록을 접어서 숨겨주는 기능!
            #region #1 if문 강의

            #endregion


            #region # Variable Type Test
            byte bNum = 5;
            short sNum = 10;
            int iNum = 50;
            float fNum = 90.5F;
            double dbNum = 100.55;
            decimal dmNum = 10000.555M;

            textBox1.Text += bNum.GetType() + " bNum: " + bNum.ToString() + "\r\n";
            textBox1.Text += sNum.GetType() + " sNum: " + sNum.ToString() + "\r\n";
            textBox1.Text += iNum.GetType() + " iNum: " + iNum.ToString() + "\r\n";
            textBox1.Text += fNum.GetType() + " fNum: " + fNum.ToString() + "\r\n";
            textBox1.Text += dbNum.GetType() + " dbNum: " + dbNum.ToString() + "\r\n";
            textBox1.Text += dmNum.GetType() + " dmNum: " + dmNum.ToString() + "\r\n";
            #endregion

            // # 문자열 보간
            #region

            //$"{표현식}"
            //- 안에 있는 코드를 계산하고 자동으로 문자열로 만들어준다! 깔끔, 가독성 굳.
            //- E.g) textBox1.Text += $"{3 + 5}\n";

            int a = 10;
            int b = 2;

            textBox1.Text += $"\r\n{a + b}\r\n";
            textBox1.Text += $"{a - b}\r\n";
            textBox1.Text += $"{a * b}\r\n";
            textBox1.Text += $"{a / b}\r\n";
            textBox1.Text += $"{a % b}\r\n";
            textBox1.Text += $"{a == b}\r\n";
            #endregion

            #region # 문자열 보간 사용하기
            // Q1
            string fruit = "Mango";
            int fruitPrice = 3500;
            int cnt = 6;
            int sum = fruitPrice * cnt;
            textBox1.Text = $"{fruit} {cnt}개의 총 가격은 {sum}원입니다.\r\n\r\n";

            // Q2
            string typeCasting = "15";
            textBox1.Text += $"15에 10을 더하면 {int.Parse(typeCasting) + 10}입니다.";

            // Q3
            string stuff = "노트북";
            int price1 = 1200000;
            float discount = 0.15f;
            byte leftCount = 8;
            bool isAvailable = (leftCount > 0) ? true: false;

            double finalPrice = Math.Round(price1 * (1 - discount), 2);
            textBox1.Text = (leftCount > 0) ?  $"구매 가능: 할인 가격은 {finalPrice}원입니다." : "품절되었습니다.";
            textBox2.Text = (leftCount >= 5) ? "여유 있음" : "소량 남음";
            textBox3.Text = $"상품명: {stuff}, 할인된 가격: {finalPrice}, 재고: {leftCount}개";
            

            //Q3 Damon leader님 풀이
            
            string productName = "노트북";
            int price = 1200000;
            float discountRate = 0.15f;
            byte stock = 8;

            double discountedPrice = price * (1 - discountRate);
            textBox1.Text = (isAvailable) ? "구매 가능: 할인 가격은 " + discountedPrice.ToString("N0") + "원입니다." : "품절되었습니다.";
            
            /*
            # 소수점 포맷 설정!!
                - 포맷 조정은 "출력용" 변환이다. 계산 자체가 바뀌진 않는다!
                - "N0"은 천 단위 구분 쉼표(,)를 찍어주는 서식이다.
                - "P1"은 퍼센트로 변환해서 소수 첫째 자리까지
                - "0"은 자리 수 채움 (0으로 채운다)
                - "0.0"은 소수점 첫째 자리까지, 없으면 0으로 채운다.
                - "0.00"은 소수점 둘째 자리까지, 없으면 0으로 채운다.
                - "0.###"은 소수점 세 자리까지, 있으면 표시, 없으면 표시 안 함.
                - "N2"는 쉼표 + 소수 둘째 자리까지.
            */
            #endregion

            #region # The Built-in Functions in String namespace
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
            #endregion

            #region # Use a Function!

            int[] array = Add(30, 7);
            textBox1.Text = String.Join(", ", array);
            #endregion

            #region # If statement

            if (Coin(true))
            {
                textBox1.Text = "승리";
            }
            else
            {
                textBox1.Text = "패배";
            }
            #endregion

            #region # String Methods Practice #2

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
            text = text.Remove(idxList[0], 1);
            string[] tempList = text.Split(' ');
            textBox1.Text += string.Join(",", tempList);
            #endregion


            #region

            Food food = 0;

            string animal = "Cat";
            switch (animal)
            {
                case "Dog":
                    MessageBox.Show("Dog!");
                    break;
                case "Cat":
                    MessageBox.Show("Cat!");
                    break;
                default:
                    MessageBox.Show("Nothing!");
                    break;
            }

            //같은 enum 타입끼리만 비교 연산 가능! (서로 다른 enum 타입은 비교 불가!)

            switch (food)
            {
                case Food.Pizza:
                    MessageBox.Show("Pizza");
                    break;
                case Food.Burger:
                    MessageBox.Show("Burger");
                    break;
                case Food.Pasta:
                    MessageBox.Show("Pasta");
                    break;
                case Food.Kimchi:
                    MessageBox.Show("Kimchi");
                    break;
                default:
                    MessageBox.Show("welcome!");
                    break;
            }
            #endregion

            #region
            /*goto
             * 특정한 라벨(label)로 점프해서 코드를 실행하도록 하는 명령문(제어)
             * 코드 순서를 무시하고,
             * 
             * 가독성 저하 / 유지보수 어려움 / 코드 흐름에 혼란 야기
             */
            //case#1
            int selection = 0;
            textBox_result.Text += "Start \r\n";

        Location:
            textBox_result.Text += "Location \r\n";

            if(selection == 0)
            {
                textBox_result.Text += "if 문 안 \r\n";

                selection = 1;

                goto Location;
            }


            //case#2
            // goto & switch
            // switch에서 goto case를 쓰는 목적! Why?
            //여러 case에서 같은 코드를 실행해야 할 때, 중복 없이 깔끔하게 처리 가능

            CoffeeMenu choice = CoffeeMenu.WithIceCream;

            switch (choice)
            {
                case CoffeeMenu.Plain:
                    textBox_result.Text += "Coffee";
                    break;
                case CoffeeMenu.WithMilk:
                    textBox_result.Text += "Milk";
                    break;
                case CoffeeMenu.WithIceCream:
                    textBox_result.Text += "IceCream";
                    break;
            }
            #endregion

            #region #for statement
            int forSum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    forSum += i;
                }
            }
            Console.WriteLine(sum);
            #endregion

            #region #for statement
            //1
            for (int i = 2; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }

            //2
            int maxLine = 4;
            string starText = "";
            for (int i = 1; i <= maxLine; i++)
            {
                for (int j = 1; j <= maxLine - i; j++)
                {
                    starText += " ";
                }
                for (int j = 1; j <= i; j++)
                {
                    starText += "*";
                }
                starText += "\r\n";
            }

            //3
            for (int i = 1; i <= maxLine; i++)
            {
                for (int j = 1; j <= maxLine - i; j++)
                {
                    starText += " ";
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    starText += "*";
                }
                starText += "\r\n";
            }
            
            Console.WriteLine(starText);
            #endregion

            #region #foreach statement
            int[] scores = { 85, 90, 78, 92, 88 };
            int foreachSum = 0;

            foreach (int score in scores)
            {
                foreachSum += score;
            }

            double average = (double)foreachSum / scores.Length;
            Console.WriteLine("총합 : " + foreachSum);
            Console.WriteLine("평균 : " + average);
            Console.WriteLine("=================");
            #endregion
        }

        //===============================================================//

        #region
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int num=0;
            int.TryParse(this.textBox1.Text, out num);
            this.textBox1.Text = (++num).ToString();
        }
        #endregion

        #region
        int[] Add(int x, int y)
        {
            int[] array = new int[2];
            array[0] = x / y;
            array[1] = x % y;
            return array;
        }
        #endregion

        #region
        bool Coin(bool coinTF)
        {
            Random random = new Random();
            int result = random.Next(0, 100) % 2;
            if ( (result == 1 && coinTF == true) || (result == 0 && coinTF == false))
            {
                return true;
            }
            return false;
        }
        #endregion



        #region #Receive input value and use the Coin() function
        
        private string boolValue;
        private void button_input_Click(object sender, EventArgs e)
        {
            #region #Debugging Test
            //Console.WriteLine("textBox : " + textBox_input.Text + "radioButton : " + boolValue);
            //Console.WriteLine("textBox : " + (textBox_input.Text == "") + " radioButton : " + (boolValue==null));
            #endregion

            if (textBox_input.Text == "" && this.boolValue == null) //textBox에도, RadioButton에도 값이 없다면 에러 메시지 출력
            {
                textBox_result.Text = "ERROR : You didn't pick any option!";
                return;
            }
            else if (textBox_input.Text != "true" && textBox_input.Text != "false" && this.boolValue == null) //유효하지 않은 값에 대해 처리
            {
                textBox_result.Text = "invalid value!";
                return;
            }

            if (textBox_input.Text != "") //textBox에 담긴 값 우선 확인
            {
                boolValue = textBox_input.Text;
            }

            textBox_result.Text = Coin(Convert.ToBoolean(boolValue)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            boolValue = "true";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            boolValue = "false";
        }
        #endregion


        #region
        private void button_input_Click1(object sender, EventArgs e)
        {
            string msg = string.Empty;
            Week day = InputCheck(textBox_input.Text.Trim());
            switch (day)
            {
                case Week.Sunday:
                    msg = "예헹 행복한 날이여";
                    break;
                case Week.Monday:
                    msg = "월요일 좋아~ 너무도 좋아 ^^ - 스폰지밥";
                    break;
                case Week.Tuesday:
                    msg = "자 달려볼까유~ 오늘도 열시미";
                    break;
                case Week.Wednesday:
                    msg = "벌써 주중의 중간! 뭔가 특별한 날인 듯한 느낌 ㅎㅎ";
                    break;
                case Week.Thursday:
                    msg = "뻔하지만 오늘도 열심히 ㅋㅋ!! 잘하고 이따";
                    break;
                case Week.Friday:
                    msg = "이제 주말이고만~~~ 주말엔 어떻게 보내볼까?!";
                    break;
                case Week.Saturday:
                    msg = "뒹굴뒹굴, 햇살도 쫌 쬐고, 누려보자~!";
                    break;
                default:
                    msg = "잘못 입력했어요 :( 다시 입력해주세요!";
                    break;
            }
            textBox_result.Text = msg;
        }

        //유효성 검사!! (주로 기업 프로젝트에서 이런 식으로 많이 한다.
        Week InputCheck(string day)
        {
            switch (day)
            {
                case "Sunday":
                    return Week.Sunday;
                case "Monday":
                    return Week.Monday;
                case "Tuesday":
                    return Week.Tuesday;
                case "Wednesday":
                    return Week.Wednesday;
                case "Thursday":
                    return Week.Thursday;
                case "Friday":
                    return Week.Friday;
                case "Saturday":
                    return Week.Saturday;
                default:
                    return Week.none;
            }
        }
        #endregion

        #region
        private void button1_input_Click(object sender, EventArgs e)
        {
            int stCount;
            bool isParsed = int.TryParse(textBox_input.Text, out stCount);
            /*
             int.TryParse(string 입력값, out 변수명)
             -> 사용자 입력이 숫자인지 안전하게 확인하게 해주는 메서드.
             -> 문자열을 숫자로 변환할 때 변환이 가능한 경우에만 값을 저장하고, true를 반환
             -> 변환에 실패하더라도 오류를 발생시키지 않고 false를 반환한다!
             ** TryParse()는 성공 여부와 변환된 값을 동시에 반환해야 하기 때문에, 두 개의 값을 반환해야 함.
             ** 그래서 bool은 리턴값, 정수 결과는 out 키워드를 사용해서 바깥 변수에 저장하는 구조.
             */
            textBox_result.Text = ""; //initialize

            if (!isParsed) //error catch
            {
                MessageBox.Show("Please put the number");
            }
            else
            {
                Random r = new Random();
                int[] stScore = new int[stCount];
                string[] stName = new string[stCount];
                for (int i = 0; i < stCount; i++)
                {
                    stName[i] = "학생" + (i + 1).ToString();
                    stScore[i] = r.Next(0, 101);
                    textBox_result.Text += printScore(stName[i], stScore[i]);
                }
            }
        }

        string printScore(string name, int score)
        {
            return name + "의 점수: " + score + "점\r\n";
        }
        #endregion

        #region #Rock Paper Scissor shoot game
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
        #endregion

        #region #Struct Practice#1
        /*void executeProgram()
        {
            string[] input1;
            string[] input2;

            //get x, y value from user
            Console.WriteLine("첫 번째 x, y 좌표를 입력하세요 (예시: 3 5)");
            input1 = Console.ReadLine().Split(' ');
            while (input1.Length < 2)
            {
                Console.WriteLine("다시 입력해주세요");
                input1 = Console.ReadLine().Split(' ');
            }

            Console.WriteLine("두 번째 x, y 좌표를 입력하세요");
            input2 = Console.ReadLine().Split(' ');
            while (input2.Length < 2)
            {
                Console.WriteLine("다시 입력해주세요");
                input2 = Console.ReadLine().Split(' ');
            }

            Point p1 = new Point();
            Point p2 = new Point();
            p1.x = int.Parse(input1[0]);
            p1.y = int.Parse(input1[1]);
            p2.x = int.Parse(input2[0]);
            p2.y = int.Parse(input2[1]);

            Console.WriteLine(Point.Diff_xy(p1, p2).ToString("0.00"));
        }*/
        #endregion

        #region #Struct Practice#2
        /*void executeProgram()
        {
            string[] splited;
            Student[] s = new Student[3];

            Console.WriteLine("=========Student Record=========\r\n학생의 정보(이름, 나이, 점수)를 입력하세요 (예: 홍길동, 23, 97)");
            int cnt = 0;
            while (cnt < 3)
            {
                Console.Write($"학생{cnt + 1}의 정보 : ");
                splited = Console.ReadLine().Split(',');
                if (splited.Length == 3)
                {
                    try
                    {
                        s[cnt] = new Student(splited[0], int.Parse(splited[1]), Convert.ToDouble(splited[2]));
                        cnt++;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("=== ERROR ===");
                    }
                }
            }
            for (int i = 0; i < cnt; i++)
            {
                Student.printStudent(s[i]);
            }
        }*/
        #endregion
    }
}