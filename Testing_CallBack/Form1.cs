using System;
using System.Windows.Forms;

namespace Testing_CallBack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 创建事件触发器实例
            EventTrigger trigger = new EventTrigger();

            // 创建事件处理器实例
            EventProcessor processor = new EventProcessor();

            // 订阅事件，将处理器的回调方法注册到触发器
            processor.Subscribe(trigger);

            // 触发事件，并传递消息 "Hello, World!"
            trigger.TriggerEvent("Hello, World!");

            // 再次触发事件，并传递不同的消息 "Another event"
            trigger.TriggerEvent("Another event");
        }
    }

    // 定义一个委托类型，用于回调函数
    public delegate void EventCallback(string message);

    // 事件触发器类
    public class EventTrigger
    {
        // 定义一个私有事件，使用 EventCallback 委托
        private event EventCallback OnEventTriggered;

        // 注册回调函数的方法
        public void RegisterCallback(EventCallback callback)
        {
            // 将回调函数添加到事件中
            OnEventTriggered += callback;
        }

        // 触发事件的方法
        public void TriggerEvent(string message)
        {
            // 调用事件，通知所有注册的回调函数
            OnEventTriggered?.Invoke(message);
        }
    }

    // 事件处理器类
    public class EventProcessor
    {
        // 事件处理方法，符合 EventCallback 委托签名
        public void ProcessEvent(string message)
        {
            // 打印接收到的事件消息
            Console.WriteLine("Event received: " + message);
        }

        // 订阅事件的方法
        public void Subscribe(EventTrigger trigger)
        {
            // 将 ProcessEvent 方法注册为事件触发器的回调函数
            trigger.RegisterCallback(ProcessEvent);
        }
    }
}
