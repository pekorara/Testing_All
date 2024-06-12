using System;
using System.Drawing;
using System.Windows.Forms;

namespace Testing_Chart.UC
{
    public partial class BarChart : UserControl
    {

        private Random _rand = new Random();

        public BarChart()
        {
            InitializeComponent();

            var series1 = chart1.Series["飲料"];
            var series2 = chart1.Series["水果"];

            series1.Points.AddXY("兒童", _rand.Next(1, 100));
            series1.Points.AddXY("青少年", _rand.Next(1, 100));
            series1.Points.AddXY("青年", _rand.Next(1, 100));
            series1.Points.AddXY("老人", _rand.Next(1, 100));

            series2.Points.AddXY("類別1", _rand.Next(1, 100)); 
            series2.Points.AddXY("類別2", _rand.Next(1, 100));
            series2.Points.AddXY("類別3", _rand.Next(1, 100));
            series2.Points.AddXY("類別4", _rand.Next(1, 100));

            // 添加標籤並設置格式
            foreach (var point in series1.Points)
            {
                point.Label = $"{point.YValues[0]}";
                point.LabelForeColor = Color.Black;
            }

            foreach (var point in series2.Points)
            {
                point.Label = $"{point.YValues[0]}";
                point.LabelForeColor = Color.Black;
            }

        }
    }
}
