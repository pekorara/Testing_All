using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Testing_OCP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IReportGenerator pdfReportGenerator = new PdfReportGenerator();
            Report pdfReport = new Report(pdfReportGenerator);
            pdfReport.GenerateReport();

            IReportGenerator csvReportGenerator = new CsvReportGenerator();
            Report csvReport = new Report(csvReportGenerator);
            csvReport.GenerateReport();
        }
    }



    //BadReport
    //public class Report
    //{
    //    public void GenerateReport(string reportType)
    //    {
    //        if (reportType == "PDF")
    //        {
    //            Console.WriteLine("Generating PDF report...");
    //        }
    //        else if (reportType == "CSV")
    //        {
    //            Console.WriteLine("Generating CSV report...");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Report type not supported.");
    //        }
    //    }
    //}
}
