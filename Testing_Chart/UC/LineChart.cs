using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms.DataVisualization.Charting;

namespace Testing_Chart.UC
{
    public partial class LineChart : UserControl
    {
        private Random _rand = new Random();

        public LineChart()
        {
            InitializeComponent();

            chart1.Series["Series1"].Points.Clear();
            var series1 = chart1.Series["Series1"];

            // 设置系列属性
            series1.ChartType = SeriesChartType.Pyramid;
            series1.Color = Color.Blue;
            series1.BorderWidth = 2;
            series1.ShadowOffset = 1;

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

            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;

            // 设置图表区域属性
            chart1.ChartAreas[0].BackColor = Color.LightYellow;
            chart1.ChartAreas[0].BorderColor = Color.Gray;
            chart1.ChartAreas[0].BorderWidth = 2;

            // 设置金字塔图特有的属性
            series1["Pyramid3DRotationAngle"] = "10";
            series1["PyramidInsideLabelStyle"] = "Outside";
            series1["PyramidOutsideLabelPlacement"] = "Right";
            series1["PyramidValueType"] = "Linear";

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
