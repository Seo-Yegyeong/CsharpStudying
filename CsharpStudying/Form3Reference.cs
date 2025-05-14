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
    public partial class Form3Reference : Form
    {
        public Form3Reference()
        {
            InitializeComponent();

            #region Reference (ref, out)
            //기본 값 전달 방식
            // #1. basic 
            int num = 10;
            ChangeValue(num);
            Console.WriteLine(num); // 결과 : 10 (메모리 참조 방식이 아닌 값을 복사하여 전달한 것이기 때문에 원본 num은 전혀 바뀌지 않는다.

            /*
            * ref, out 키워드 값 전달 방식
            * Why?
            * - 메서드에서 변수의 *"원본 값을 직접 수정하거나"*
            *   return을 보완하여 *"여러 값을 반환"*하고 싶을 때 사용함.
            *   => 값 복사(x) 대신 *"참조 전달"* 방식!
            *   
            * 공통점:
            * - 둘 다 "참조 전달" 방식이므로, 메서드 내부에서 변경된 값이 "외부에도 반영"됨.
            * - ref나 out을 사용할 때는, 함수 정의부와 호출부 모두 키워드를 명시해야 하며,
            *   그렇지 않으면 컴파일 오류가 발생.
            *   
            * 차이점:
            * [ref]
            * - "입력 + 출력" 목적
            * - 호출 전 변수는 반드시 "초기화"되어 있어야 함.
            * - 메서드 안에서 값을 바꿀 수도, 안 바꿀 수도 있음 (선택)
            * 
            * [out]
            * - "출력 전용" 목적
            * - 호출 전 변수는 초기화되어 있을 필요 없음.
            * - 메서드 안에서 반드시 값을 할당해야 함. (필수)
            * 
            * When?:
            * - ref: 기존 값을 받아서 내부에서 수정하고 싶을 때
            * - out: return 처럼 내부에서 새 값을 만들어서 돌려주고 싶을 때 (여러 값 반환 가능)
            */
            
            // #2. ref
            int numRef = 10;
            ChangeRef(ref numRef);
            Console.WriteLine(numRef);

            // #3. out
            int numOut; //초기화하지 않아도 됨.
            ChangeOut(out numOut);
            Console.WriteLine(numOut);
            #endregion


            #region Practice
            // 실습1. ref 키워드를 활용한 배열 채우기
            Console.Write("How long array do you want? ");
            try
            {
                int[] arrRef = new int[int.Parse(Console.ReadLine())];
                SetArrayRef(ref arrRef);
                Console.Write("[ref] 배열 값: ");
                foreach (int i in arrRef) Console.Write(i + " ");
                Console.Write("\r\n--------------------------------\r\n");
            }
            catch
            {
                MessageBox.Show("Error! Put the number");
            }

            // 실습2. out 키워드를 활용한 배열 생성 및 채우기
            int[] arrOut;
            Console.Write("How long array do you want? ");
            if (int.TryParse(Console.ReadLine(), out int len)) SetArrayOut(out arrOut, len);
            else { return; }
            Console.Write("[out] 배열 값: ");
            foreach (int i in arrOut) Console.Write(i + " ");
            #endregion
        }

        #region Functions
        void ChangeValue(int x) => x = 99; // 복사된 x 값만 바뀌고 num은 그대로임.
        void ChangeRef(ref int x) => x = 99;
        void ChangeOut(out int x) => x = 100;


        // 실습1. ref 키워드 활용 함수
        void SetArrayRef(ref int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++) arr[i] = i + 1;
        }

        // 실습2. out 키워드 활용 함수
        void SetArrayOut(out int[] arr, int len)
        {
            arr = new int[len];
            for (int i = 0; i < len; i++) arr[i] = i + 1;
        }
        #endregion
    }
}
