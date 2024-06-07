using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                // 处理订单的逻辑
                Console.WriteLine($"Order {order.Id} is processed.");
            }
            else
            {
                Console.WriteLine($"Order {order.Id} is invalid.");
            }
        }
    }
}
