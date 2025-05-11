using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

//생각 후 코딩 :D

namespace CsharpStudying
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

    public partial class Form1 : Form
    {
        /* [사용자 Class]
            Field
            - 이름 (string name)
            - 개인 식별 ID (string userID)
            - 이번달 지출 합계 (int sum)
            
            Method
            - field 초기화 (Constructor)
            - 구매 시 지출합계 재연산


           [자판기 Class]
            Field
            - 음료 이름 (string[] name)
            - 음료 가격 (int[] price)
            - 재고 (int[] price)
            
            Method
            - Constructor
            - 음료 이름 받아 가격 반환 함수
            - 재고 확인 함수
         */ 
        /*struct User
        {
            public string name;
            public int userId;
            public int money;

            public static void Pay()
            {

            }
        }

        struct Machine
        {
            public string[] name;
            public int[] price;
            
            public void PutProduct(int idx)
            {

            }

            public int ReturnPrice(string name)
            {
                int i = 0;
                foreach(string s in this.name)
                {
                    if(s == name)
                    {

                    }
                }
                return 0;
            }
        }
        */


        public Form1()
        {
            InitializeComponent();
            executeProgram();
        }

        void executeProgram()
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
        }
    }
}