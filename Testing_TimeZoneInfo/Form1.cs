using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Testing_TimeZoneInfo
{
    public partial class Form1 : Form
    {
        private TimeZoneInfo timeOfset;

        public Form1()
        {
            InitializeComponent();

            //多時區職間
            comboBox1.DataSource = TimeZoneInfo.GetSystemTimeZones().Where(t => t.BaseUtcOffset.Minutes == 0).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeOfset = (TimeZoneInfo)comboBox1.SelectedItem;
            MessageBox.Show(DateTimeOffset.Now.ToOffset(timeOfset.BaseUtcOffset).ToString());
            MessageBox.Show(DateTimeOffset.UtcNow.ToOffset(timeOfset.BaseUtcOffset).ToString());
        }
    }
}
