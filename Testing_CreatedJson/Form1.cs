using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Windows.Forms;

namespace Testing_CreatedJson
{
    public partial class Form1 : Form
    {

        Dictionary<string, object> ticketAmount = new Dictionary<string, object>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ticketAmount["2022/8/1"] = new { NormalAmount = 123123, SuspendedAmount = 0 };

            var jsonData = new
            {
                DatePeriod = new
                {
                    From = "2022/1/1",
                    To = "2023/1/1"
                },
                ChartName = "Ticket Amount",
                GeneratedOn = $"{DateTime.Now:yyyy/M/dd}",
                ChartData = ticketAmount
            };

            string jsonContent = JsonSerializer.Serialize(jsonData, new JsonSerializerOptions { WriteIndented = true });
            label1.Text = jsonContent;
        }
    }
}
