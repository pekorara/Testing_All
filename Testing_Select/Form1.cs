using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_Select
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<Order> Orders = new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    Tickets = new List<Ticket>
                    {
                        new Ticket { TicketId = 1, TicketName = "Ticket1" },
                        new Ticket { TicketId = 2, TicketName = "Ticket2" }
                    }
                },
                new Order
                {
                    OrderId = 2,
                    Tickets = new List<Ticket>
                    {
                        new Ticket { TicketId = 3, TicketName = "Ticket3" },
                        new Ticket { TicketId = 4, TicketName = "Ticket4" }
                    }
                }
            };

            var ticketsCollections = Orders.Select(x => x.Tickets);

            foreach (var item in ticketsCollections)
            {
                foreach (var x in item)
                {
                    Console.WriteLine(x.TicketName);
                }
            }

        }
    }

    public class Ticket
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; }
    }

    public class Order
    {
        public int OrderId { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
