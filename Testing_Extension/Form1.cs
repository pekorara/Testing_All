using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Extension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //字符串的擴充方法
            string email = "example@example.com";
            Console.WriteLine(email.IsValidEmail() ? "The email is valid." : "The email is not valid.");

            // 使用整数集合
            List<int> intNumbers = new List<int> { 1, 2, 3, 4, 5 };
            int intMax = intNumbers.MaxOrDefault();
            Console.WriteLine("Max int value: " + intMax); // 输出: Max int value: 5

            // 使用字符串集合
            List<string> stringList = new List<string> { "apple", "banana", "cherry" };
            string stringMax = stringList.MaxOrDefault();
            Console.WriteLine("Max string value: " + stringMax); // 输出: Max string value: cherry

            // 使用空集合
            List<int> emptyList = new List<int>();
            int emptyMax = emptyList.MaxOrDefault();
            Console.WriteLine("Max value in empty list: " + emptyMax); // 输出: Max value in empty list: 0

            //日期時間的擴充方法
            DateTime startDate = new DateTime(2024, 1, 1);
            DateTime endDate = new DateTime(2024, 12, 31);
            int daysBetween = startDate.DaysBetween(endDate);
            Console.WriteLine("Days between: " + daysBetween);
        }
    }
}
