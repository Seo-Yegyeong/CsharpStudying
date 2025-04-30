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
using System.Text; // 문자열과 관련된 기능을 제공하는 namespace
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpStudying // 프로젝트 이름.
{
    public partial class Storage : Form
    // Form1 이라는 이름의 클래스. Form 클래스를 상속받음.
    // .NET에서 제공하는 기본 윈도우 창인 Form 클래스를 상속 받아서, 윈도우 창의 기본 동작과 속성을 물려받음.
    // partial : 이 클래스는 코드가 여러 파일로 나눠져 있음을 의미.
    {
        public Storage() // Form1 클래스의 생성자 (constructor)
        {
            InitializeComponent(); // Form에 포함된 UI 요소들을 초기화하는 메서드 호출. 버튼, 텍스트박스 등 디자인 도구에서 만든 컨트롤들을 실제로 생성하고 속성 설정하는 코드들이 있음. Form 실행될 때 꼭 호출되어야 윈도우 폼이 제대로 보인다!

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

            if (coin(true))
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
        }


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
        bool coin(bool coinTF)
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
    }
}