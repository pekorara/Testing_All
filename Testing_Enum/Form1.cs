using System;
using System.Windows.Forms;

namespace Testing_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            throw new OperationFailedException(ResultCodeEnum.EmailAlreadyExists, "Email 已被註冊過");
            // 使用基本 enum
            //DayOfWeek today = DayOfWeek.Monday;
            // Console.WriteLine($"Today is {today}");

            // 遍历 enum
            //foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}

            // 使用带有标志的 enum
            //FileAccess access = FileAccess.Read | FileAccess.Write;
            //Console.WriteLine($"Access flags: {access}");

            //if ((access & FileAccess.Read) == FileAccess.Read)
            //{
            //    Console.WriteLine("Read access is set.");
            //}

            //if ((access & FileAccess.Write) == FileAccess.Write)
            //{
            //    Console.WriteLine("Write access is set.");
            //}

            // 转换 enum 到字符串
            //string dayString = today.ToString();
            //Console.WriteLine(dayString);

            // 从字符串转换到 enum
            //DayOfWeek parsedDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), "Monday");
            //Console.WriteLine(parsedDay);

            // 获取 enum 的整数值
            //int dayValue = (int)today;
            //Console.WriteLine(dayValue);
        }
    }

    public enum ResultCodeEnum : int
    {
        /// <summary>
        /// 未處理的例外
        /// </summary>
        UnHandleException = 1,
        /// <summary>
        /// 資料驗證失敗
        /// </summary>
        DataValidationFailed = 2,
        EmailAlreadyExists = 3,
        EmailOrPasswordIncorrect = 5,
        TokenValidationFailed = 6,
        AccountRoleForbidden = 7,
        DataNotExist = 8,
        SequenceAtLeastOneElement = 9,
        ProductInsufficient = 10,
        ProductNotOnSale = 11,
        OrderMultipleSeller = 12,
        OrderStatusIncorrect = 13,
        OrderNotBelongBuyer = 14,
        OrderNotBelongSeller = 15,
        InvalidFileFormat = 16
    }


    public enum DayOfWeek
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }

    [Flags]
    public enum FileAccess
    {
        Read = 1,
        Write = 2,
        Execute = 4
    }

    public class OperationFailedException : Exception
    {
        /// <summary>
        /// 初始化執行個體
        /// </summary>
        /// <param name="resultCode"></param>
        public OperationFailedException(ResultCodeEnum resultCode)
        {
            this.ResultCode = resultCode;
        }
        /// <summary>
        /// 初始化執行個體
        /// </summary>
        /// <param name="resultCode"></param>
        /// <param name="message"></param>
        public OperationFailedException(ResultCodeEnum resultCode, string message)
            : base(message)
        {
            this.ResultCode = resultCode;
        }
        /// <summary>
        /// 初始化執行個體
        /// </summary>
        /// <param name="resultCode"></param>
        /// <param name="innerException"></param>
        public OperationFailedException(ResultCodeEnum resultCode, Exception innerException)
            : base("Operation Fail", innerException)
        {
            this.ResultCode = resultCode;
        }
        /// <summary>
        /// 取得處理結果代碼
        /// </summary>
        public ResultCodeEnum ResultCode { get; private set; }
    }
}
