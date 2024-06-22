using System;
using System.Data.Entity;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Testing_Include
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            //using (var db = new DB())
            //{

            //    db.Database.Log += Console.WriteLine;
            //    var acocunt = db.Accounts
            //        .Include(t => t.Orders)
            //        .Include(t => t.Orders.Select(x => x.Tickets))
            //        .Single(t => t.ID.ToString() == "198eaea2-9578-ce16-4cf6-000bbbd22af3");

            //    foreach (var order in acocunt.Orders.ToList())
            //    {
            //        Console.WriteLine(order.OrderNumber);
            //        Console.WriteLine(order.Amount.ToString("#,##0.00"));
            //        Console.WriteLine(order.Discount.ToString("#,##0.00"));
            //        Console.WriteLine(order.PaidTime.HasValue ? order.PaidTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "N/A");
            //        Console.WriteLine(order.CreatedTime);
            //        Console.WriteLine(order.Tickets.Count());
            //    }

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
        }
    }
}
