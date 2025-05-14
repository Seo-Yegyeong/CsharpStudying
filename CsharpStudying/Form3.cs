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

            try
            {
                Console.Write("Input your new Nickname : ");
                string nickname = Console.ReadLine();

                if (nickname.Length == 0)
                {
                    throw new Exception("닉네임을 입력해주세요!");
                }
                if (nickname.Length < 2)
                {
                    throw new Exception("닉네임은 2글자 이상이어야 합니다!");
                }
                if (nickname.Contains("admin"))
                {
                    throw new Exception("닉네임에 'admin'은 포함될 수 없습니다.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }

        }
    }
}
