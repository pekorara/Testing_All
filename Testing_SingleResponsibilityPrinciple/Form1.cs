using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_SingleResponsibilityPrinciple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 使用範例
            Order order = new Order();
            order.AddItem("Item1");
            order.AddItem("Item2");
            order.CustomerEmail = "customer@example.com";

            PriceCalculator calculator = new PriceCalculator();
            decimal totalPrice = calculator.CalculateTotalPrice(order);
            Console.WriteLine($"Total price: {totalPrice}");

            EmailSender emailSender = new EmailSender();
            emailSender.SendConfirmationEmail(order.CustomerEmail);

            OrderRepository repository = new OrderRepository();
            repository.SaveOrder(order);
        }
    }
}
