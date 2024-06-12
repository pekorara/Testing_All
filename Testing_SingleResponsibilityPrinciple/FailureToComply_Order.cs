using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_SingleResponsibilityPrinciple
{
    // 訂單類別
    internal class FailureToComply_Order
    {
        public List<string> Items { get; private set; } = new List<string>();
        public string CustomerEmail { get; set; }

        public void AddItem(string item)
        {
            Items.Add(item);
        }

        // 計算總價
        public decimal CalculateTotalPrice()
        {
            // 假設每個商品價格都是10
            return Items.Count * 10;
        }

        // 發送訂單確認郵件
        public void SendConfirmationEmail()
        {
            Console.WriteLine($"Sending confirmation email to {CustomerEmail}");
        }

        // 儲存訂單到資料庫
        public void SaveOrder()
        {
            Console.WriteLine("Saving order to the database.");
        }
    }
}
