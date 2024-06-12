using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_OCP
{
    // 報告生成器介面
    public interface IReportGenerator
    {
        void GenerateReport();
    }

    // PDF報告生成器
    public class PdfReportGenerator : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating PDF report...");
        }
    }

    // CSV報告生成器
    public class CsvReportGenerator : IReportGenerator
    {
        public void GenerateReport()
        {
            Console.WriteLine("Generating CSV report...");
        }
    }

    // 報告類別
    public class Report
    {
        private readonly IReportGenerator _reportGenerator;

        public Report(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport()
        {
            _reportGenerator.GenerateReport();
        }
    }
}
