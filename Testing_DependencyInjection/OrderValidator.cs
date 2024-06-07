using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_DependencyInjection.DTO;
using Testing_DependencyInjection.Interface;

namespace Testing_DependencyInjection
{
    public class OrderValidator : IOrderValidator
    {
        public bool IsValid(Order order)
        {
            return true;
        }
    }
}
