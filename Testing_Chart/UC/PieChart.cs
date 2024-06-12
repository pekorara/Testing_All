using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Testing_Chart.UC
{
    public partial class PieChart : UserControl
    {

        private Random _rand = new Random();

        public PieChart()
        {
            InitializeComponent();
        }

        private void doughnut_generate_Click(object sender, EventArgs e)
        {
            chart2.Series["Series1"].Points.Clear();
            chart2.Titles["Title1"].Text = "西亞圖";
            chart2.Series["Series1"].Points.AddXY("影片", _rand.Next(1,100));
            chart2.Series["Series1"].Points.AddXY("照片", _rand.Next(1, 100));
            chart2.Series["Series1"].Points.AddXY("動畫", _rand.Next(1, 100));
            chart2.Series["Series1"].Points.AddXY("GIF", _rand.Next(1, 100));
            chart2.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void pie_generate_Click(object sender, EventArgs e)
        {
            var series = chart1.Series["Series1"];
            series.Points.Clear();
            chart1.Titles["Title1"].Text = "西亞圖";
            series.Points.AddXY("影片", _rand.Next(1, 100));
            series.Points.AddXY("照片", _rand.Next(1, 100));
            series.Points.AddXY("動畫", _rand.Next(1, 100));
            series.Points.AddXY("GIF", _rand.Next(1, 100));
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            // 更改文字樣式
            foreach (DataPoint point in series.Points)
            {
                point.Label = point.AxisLabel + ": " + point.YValues[0].ToString();
                point.LabelForeColor = Color.Aqua;
            }

            // 設置鼠標提示
            chart1.GetToolTipText += (_, x) =>
            {
                if (x.HitTestResult.ChartElementType == ChartElementType.DataPoint)
                {
                    var point = (DataPoint)x.HitTestResult.Object;
                    x.Text = $"{point.AxisLabel}: {point.YValues[0]}";
                }
            };

        }
    }
}
