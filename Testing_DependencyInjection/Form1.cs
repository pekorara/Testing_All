using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Testing_DependencyInjection.DTO;
using Testing_DependencyInjection.Interface;

namespace Testing_DependencyInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 创建OrderValidator实例
            IOrderValidator orderValidator = new OrderValidator();

            // 使用OrderValidator实例创建OrderProcessor实例
            OrderProcessor orderProcessor = new OrderProcessor(orderValidator);

            // 创建一个订单实例
            Order order = new Order { Id = 1, TotalAmount = 100.0 };

            // 处理订单
            orderProcessor.Process(order);
        }
    }
}
