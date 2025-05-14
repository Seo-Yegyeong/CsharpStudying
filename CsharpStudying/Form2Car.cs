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
    public partial class Form2Car : Form
    {
        public Form2Car()
        {
            InitializeComponent();

            // --- #4-1. 기본 생성자
            Class2Car car1 = new Class2Car();
            car1.Speed = 20;
            car1.Color = "은색";
            car1.PrintInfo();

            Console.WriteLine("-------------------");

            // --- #4-2. 매개변수 있는 생성자
            Class2Car car2 = new Class2Car("그랜저", 50, "검정", 2024);
            car2.Accelerate(30);
            car2.PrintInfo();
            Console.WriteLine("-------------------");

            // --- #6. 메서드 사용
            car2.Brake(100);
            Console.WriteLine("-------------------");
            // --- #7. static 메서드 호출
            Class2Car.ShowTotalCars();

            Console.ReadLine();
            Console.WriteLine("================New Square Class================");
            ClassSquare s1 = new ClassSquare();
            Console.WriteLine($"s1 넓이: {s1.GetArea()}");
            Console.WriteLine("=-----------------------------------------------");

            // Use the Constructor (parameter)
            ClassSquare s2 = new ClassSquare(5);
            Console.WriteLine($"s2 넓이: {s2.GetArea()}");

            Console.ReadLine() ;
            Console.WriteLine("=================partial class==================");
        }
    }
}