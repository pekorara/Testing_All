using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "asd";

            if (2 == 2) throw new Exception("Visitors cannnot use this management system!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //dgv1.Columns["Details"].SortMode = DataGridViewColumnSortMode.Programmatic;
    }
}

//public R let<T, R>(this T self, Func<T, R> func)
//{
//    return func(self);
//}
