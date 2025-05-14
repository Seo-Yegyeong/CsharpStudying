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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            #region Reference (ref, out)
            //기본 값 전달 방식
            // #1. basic 
            //int num = 10;
            //ChangeValue(num);
            //Console.WriteLine(num); // 결과 : 10 (메모리 참조 방식이 아닌 값을 복사하여 전달한 것이기 때문에 원본 num은 전혀 바뀌지 않는다.

            /*
             ref, out 키워드 : 값 복사 아닌 참조(주소) 전달 방식
             왜 사용하는가? 메서드에서 변수의 '원본 값을 직접 수정'하거나 return을 보완하여 '여러 값을 반환하고 싶을 때' 사용함.

            공통점: 둘 다 참조 전달 방식이므로, 메서드 내부에서 변경된 값이 '외부에도 반영'됨.
                    ref나 out을 사용할 때는, 함수 정의부와 호출부 모두 

            차이점:
            [ref]
            - 입력 + 출력 목적
            - 호출 전 반드시 초기화돼 있어야 한다.
            - 메서드 안에서 값을 바꿀 수도, 안 바꿀 수도 있음 (선택)

            [out]
            - "출력 전용" 목적
            - 호출 전 변수는 초기화되어 있을 필요 없음.
            - 메서드 안에서 반드시 값을 할당해야 함 (필수)

            When?
            - ref: 기존 값을 받앗 내부에서 수정하고 싶을 때
            - out: return처럼 내부에서 새 값을 만들어서 돌려주고 싶을 때 (여러 값 반환)
            */

            // #2. ref
            //int numRef = 10;
            //ChangeRef(ref numRef);
            //Console.WriteLine(numRef);

            //// #3. out
            //int numOut; //초기화하지 않아도 됨.
            //ChangeOut(out numOut);
            //Console.WriteLine(numOut);

            #endregion

            // 실습1. ref 키워드를 활용한 배열 채우기
            Console.Write("How long array length do you want? ");
            try
            {
                int[] arrRef = new int[int.Parse(Console.ReadLine())];
                SetArray(ref arrRef);
                foreach (int i in arrRef) Console.WriteLine(i);
            }
            catch {
                MessageBox.Show("Error! Put the number");
            }

            // 실습2. out 키워드를 활용한 배열 생성 및 채우기
            //int[] arrOut;

        }

        // Functions
        //void ChangeValue(int x) => x = 99; // 복사된 x 값만 바뀌고 num은 그대로임.
        //void ChangeRef(ref int x) => x = 99;
        //void ChangeOut(out int x) => x = 100;


        // 실습1. ref 키워드 활용 함수
        void SetArray(ref int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                arr[i] = i + 1;
            }
        }
    }
}
