using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_HashSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 創建兩個 HashSet，元素類型為 string
            HashSet<string> fruits1 = new HashSet<string> { "Apple", "Banana", "Cherry" };
            HashSet<string> fruits2 = new HashSet<string> { "Banana", "Date", "Fig" };

            // 添加元素到 HashSet
            fruits1.Add("Elderberry");
            fruits2.Add("Grape");

            // 嘗試添加重複的元素
            bool isAdded = fruits1.Add("Apple"); // 這將返回 false，因為 "Apple" 已經存在於集合中
            Console.WriteLine("Attempt to add 'Apple' again to fruits1: " + isAdded);

            // 檢查元素是否存在
            bool containsBanana = fruits1.Contains("Banana");
            Console.WriteLine("fruits1 contains 'Banana': " + containsBanana);

            // 列出所有元素
            Console.WriteLine("All fruits in fruits1:");
            foreach (var fruit in fruits1)
            {
                Console.WriteLine(fruit);
            }

            // 刪除元素
            bool isRemoved = fruits1.Remove("Cherry");
            Console.WriteLine("Attempt to remove 'Cherry' from fruits1: " + isRemoved);

            // 再次列出所有元素
            Console.WriteLine("All fruits in fruits1 after removal:");
            foreach (var fruit in fruits1)
            {
                Console.WriteLine(fruit);
            }

            // 集合操作：聯集 把每個 set 加起來
            HashSet<string> union = new HashSet<string>(fruits1);
            union.UnionWith(fruits2);
            Console.WriteLine("Union of fruits1 and fruits2:");
            foreach (var fruit in union)
            {
                Console.WriteLine(fruit);
            }

            // 集合操作：交集 找到每個 set 的相同地方
            HashSet<string> intersection = new HashSet<string>(fruits1);
            intersection.IntersectWith(fruits2);
            Console.WriteLine("Intersection of fruits1 and fruits2:");
            foreach (var fruit in intersection)
            {
                Console.WriteLine(fruit);
            }

            // 集合操作：差集 計算的是 fruits1 集合中存在但在 fruits2 集合中不存在的元素
            HashSet<string> difference = new HashSet<string>(fruits1);
            difference.ExceptWith(fruits2);
            Console.WriteLine("Difference of fruits1 and fruits2 (fruits1 - fruits2):");
            foreach (var fruit in difference)
            {
                Console.WriteLine(fruit);
            }

        }
    }
}
