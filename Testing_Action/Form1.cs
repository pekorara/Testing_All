using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Action
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 使用 Action<string> 定义一个委托，指向具体的方法
            Action<string> action = PrintMessage;

            // 使用 Invoke 调用委托所指向的方法
            action.Invoke("Hello, World with Action!");

            // 也可以直接调用委托
            //action("Hello again with Action!");

            //// 使用 lambda 表达式定义 Action
            //Action<string> action2 = (msg) => Console.WriteLine("Lambda Action: " + msg);
            //action2.Invoke("Hello from Lambda Action!");
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
