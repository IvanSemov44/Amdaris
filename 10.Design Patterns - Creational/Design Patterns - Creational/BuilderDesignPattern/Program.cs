
using BuilderDesignPattern;

Report report;
ReportDirector reportDirector = new ReportDirector();

PDFReport pDFReport = new PDFReport();
report = reportDirector.MakeReport(pDFReport);
report.DisplayReport();

Console.WriteLine("------------------------");

ExcelReport excelReport = new ExcelReport();
report = reportDirector.MakeReport(excelReport);
report.DisplayReport();