
namespace BuilderDesignPattern
{
    public abstract class ReportBuilder
    {
        protected Report reportObject;

        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();

        public void CreateRepost() => reportObject = new Report();


        public Report GetReport() => reportObject;

    }
}
