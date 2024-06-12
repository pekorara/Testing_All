using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pieChartShip.Click += (_, __) => Change_chick(new UC.PieChart());

            barChartShip.Click += (_, __) => Change_chick(new UC.BarChart());

            lineChartShip.Click += (_, __) => Change_chick(new UC.LineChart());
        }

        private void Change_chick(UserControl uc)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
        }
    }
}
