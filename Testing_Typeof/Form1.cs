using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Testing_Typeof
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetAssembly(typeof(Person));

            Console.WriteLine(assembly.FullName);
            Console.WriteLine(assembly.Location);

            var a = assembly.GetTypes();

            foreach (var t in a) 
            {
                Console.WriteLine(t.FullName);
            }

            //Assembly executingAssembly = Assembly.GetExecutingAssembly();

            //Console.WriteLine(executingAssembly.FullName);

            //foreach (var item in executingAssembly.GetTypes().ToList())
            //{
            //    Console.WriteLine(item.FullName);
            //}

            //Type personType = typeof(Person);

            //Console.WriteLine(personType.FullName);

            //var person = new Person();

            //Console.WriteLine(personType);
            //Console.WriteLine(person.GetType());

            //// Type Name: Person
            //Console.WriteLine("Type Name: " + personType.Name);

            //// Properties:
            //// Name System.String
            //// Age System.Int32
            //Console.WriteLine("Properties:");
            //foreach (var prop in personType.GetProperties())
            //{
            //    Console.WriteLine(prop.Name + " " + prop.PropertyType);
            //}

            //// SayHello
            //Console.WriteLine("Methods:");
            //foreach (var method in personType.GetMethods())
            //{
            //    Console.WriteLine(method.Name);
            //}

            //// 创建 Person 类的实例
            //object personInstance = Activator.CreateInstance(personType);

            //// 设置属性值
            //PropertyInfo nameProperty = personType.GetProperty("Name");
            //nameProperty.SetValue(personInstance, "Alice");

            //PropertyInfo ageProperty = personType.GetProperty("Age");
            //ageProperty.SetValue(personInstance, 30);

            //// 调用方法
            //MethodInfo sayHelloMethod = personType.GetMethod("SayHello");
            //sayHelloMethod.Invoke(personInstance, null);

            //// 调用 Say 方法
            //MethodInfo sayMethod = personType.GetMethod("Say");
            //string sayResult = (string)sayMethod.Invoke(personInstance, new object[] { "Hello" });

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
        }

        public string Say(string say)
        {
            return $"{say} : FUCK";
        }
    }
}
