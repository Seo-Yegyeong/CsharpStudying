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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            executeProgram();
        }

        void executeProgram()
        {
            string[] splited;
            Student[] s = new Student[3];

            Console.WriteLine("=========Student Record=========\r\n학생의 정보(이름, 나이, 점수)를 입력하세요 (예: 홍길동, 23, 97)");
            int cnt = 0;
            while (cnt < 3)
            {
                Console.Write($"학생{cnt+1}의 정보 : ");
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
        }
    }
}


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