using System;
using Testing_DependencyInjection.DTO;
using Testing_DependencyInjection.Interface;

namespace Testing_DependencyInjection
{
    public class OrderProcessor
    {
        private readonly IOrderValidator _validator;

        public OrderProcessor(IOrderValidator validator)
        {
            _validator = validator;
        }

        public void Process(Order order)
        {
            if (_validator.IsValid(order))
            {
                // 處理訂單邏輯
                Console.WriteLine($"Order {order.Id} is processed.");
            }
            else
            {
                Console.WriteLine($"Order {order.Id} is invalid.");
            }
        }
    }
}
