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
    public partial class Form1 : Form
        // Form1 이라는 이름의 클래스. Form 클래스를 상속받음.
        // .NET에서 제공하는 기본 윈도우 창인 Form 클래스를 상속 받아서, 윈도우 창의 기본 동작과 속성을 물려받음.
        // partial : 이 클래스는 코드가 여러 파일로 나눠져 있음을 의미.
    {
        public Form1() // Form1 클래스의 생성자 (constructor)
        {
            InitializeComponent(); // Form에 포함된 UI 요소들을 초기화하는 메서드 호출. 버튼, 텍스트박스 등 디자인 도구에서 만든 컨트롤들을 실제로 생성하고 속성 설정하는 코드들이 있음. Form 실행될 때 꼭 호출되어야 윈도우 폼이 제대로 보인다!

            int numOfCrew; // declare a variable
            numOfCrew = 19; // use the variable
            string className = "말하기"; //
            className = "수학";

            int lineCount;
            byte buffer;

            int number = 10;
            string word = "안녕";
            // number = word; 이 코드는 형이 다르기 때문에 실행 불가.

            short word2 = 20;
            number = word2; // 이 경우에는 데이터 타입이 다르지만 int 타입이 short 타입보다 크기가 크기 때문에 데이터 복사 가능.


            textBox_print.Text += numOfCrew.GetType() + "numOfCrew: " + numOfCrew.ToString() + "\r\n";
        }
    }
}
