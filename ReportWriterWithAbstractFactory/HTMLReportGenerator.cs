namespace ReportWriterWithAbstractFactory
{
    public class HTMLReportGenerator : IReportGenerator
    {
        public IReportHeader GetReportHeader()
        {
            return new HTMLReportHeader();
        }

        public IReportContent GetReportContent()
        {
            return new HTMLReportContent();
        }

        public IReportFooter GetReportFooter()
        {
            return new HTMLReportFooter();
        }
    }
}