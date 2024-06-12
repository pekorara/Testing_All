using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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

        private void button2_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
 
            var series1 = chart2.Series["Series1"];

            // 设置系列属性
            series1.ChartType = SeriesChartType.Radar;
            series1.Color = Color.Red;
            //陰影
            series1.ShadowOffset = 10;

            // 添加数据点
            series1.Points.AddXY("兒童", _rand.Next(1, 100));
            series1.Points.AddXY("青少年", _rand.Next(1, 100));
            series1.Points.AddXY("青年", _rand.Next(1, 100));
            series1.Points.AddXY("老人", _rand.Next(1, 100));

            // 添加数据点标签
            series1.Points[0].Label = "兒童: " + series1.Points[0].YValues[0];
            series1.Points[1].Label = "青少年: " + series1.Points[1].YValues[0];
            series1.Points[2].Label = "青年: " + series1.Points[2].YValues[0];
            series1.Points[3].Label = "老人: " + series1.Points[3].YValues[0];

            // 设置图表区域属性
            chart2.ChartAreas[0].BackColor = Color.Aqua;
            chart2.ChartAreas[0].BorderColor = Color.Azure;
            chart2.ChartAreas[0].BorderWidth = 2;

            // 设置坐标轴属性
            chart2.ChartAreas[0].AxisX.Interval = 1;
            chart2.ChartAreas[0].AxisY.Maximum = 100;
            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Interval = 10;
            chart2.ChartAreas[0].AxisX.LineColor = Color.Black;
            chart2.ChartAreas[0].AxisY.LineColor = Color.Black;
        }
    }
}
