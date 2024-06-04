using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 使用初始化語法創建並初始化字典
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 },
                { "Charlie", 35 }
            };

            // 更新或添加值
            ages["Alice"] = 31; // 更新Alice的年齡
            ages["David"] = 40; // 添加新的鍵值對

            //打印所有鍵值對
            PrintDictionary(ages);

            // 合併另一個字典
            Dictionary<string, int> additionalAges = new Dictionary<string, int>
            {
                { "Eve", 28 },
                { "Frank", 33 }
            };

            foreach (var kvp in additionalAges)
            {
                ages[kvp.Key] = kvp.Value;
            }

            Console.WriteLine("After merging another dictionary:");
            PrintDictionary(ages);

            // 查找鍵
            if (ages.ContainsKey("Charlie"))
            {
                Console.WriteLine("Charlie's age: " + ages["Charlie"]);
            }

            // 排序字典（按鍵排序）
            var sortedByKey = ages.OrderBy(kvp => kvp.Key).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine("Dictionary sorted by key:");
            PrintDictionary(sortedByKey);

            // 排序字典（按值排序)
            var sortedByValue = ages.OrderBy(kvp => kvp.Value).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            Console.WriteLine("Dictionary sorted by value:");
            PrintDictionary(sortedByValue);

            // 使用 Linq 查找特定條件的元素
            var youngPeople = ages.Where(kvp => kvp.Value < 30).ToList();
            Console.WriteLine("People younger than 30:");
            foreach (var kvp in youngPeople)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }
        }

        static void PrintDictionary(Dictionary<string, int> dict)
        {
            foreach (var kvp in dict)
            {
                Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }
            Console.WriteLine();
        }
    }
}
