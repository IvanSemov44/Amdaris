
namespace BuilderDesignPattern
{
    public class ReportDirector 
    {
        public Report MakeReport(ReportBuilder reportBuilder)
        {
            reportBuilder.CreateRepost();
            reportBuilder.SetReportType();
            reportBuilder.SetReportHeader();
            reportBuilder.SetReportContent();
            reportBuilder.SetReportFooter();

            return reportBuilder.GetReport();
        } 
    }
}
