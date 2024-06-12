using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_SingleResponsibilityPrinciple
{
    // 訂單類別，只負責訂單的管理
    public class Order
    {
        public List<string> Items { get; private set; } = new List<string>();
        public string CustomerEmail { get; set; }

        public void AddItem(string item)
        {
            Items.Add(item);
        }
    }

    // 計算價格的類別
    public class PriceCalculator
    {
        public decimal CalculateTotalPrice(Order order)
        {
            // 假設每個商品價格都是10
            return order.Items.Count * 10;
        }
    }

    // 發送郵件的類別
    public class EmailSender
    {
        public void SendConfirmationEmail(string email)
        {
            Console.WriteLine($"Sending confirmation email to {email}");
        }
    }

    // 儲存訂單的類別
    public class OrderRepository
    {
        public void SaveOrder(Order order)
        {
            Console.WriteLine("Saving order to the database.");
        }
    }
}
