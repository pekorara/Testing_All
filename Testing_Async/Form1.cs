using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");

            await Task.Run(async () =>
            {
                await Task.Delay(1000);
                MessageBox.Show("Task1");
            });

            await Task.Run(async () =>
            {
                await Task.Delay(3000);
                MessageBox.Show("Task2");
            });

            MessageBox.Show("Finish");
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            List<Task> tasks = new List<Task>();

            MessageBox.Show("Test");

            for (int i = 0; i < 10000; i+=1000)
            {
                tasks.Add(Task.Run(async () =>
                {
                    await Task.Delay(i);
                    MessageBox.Show("Task1");
                }));
            }

            await Task.WhenAll(tasks);

            MessageBox.Show("Finish");
        }
    }
}
