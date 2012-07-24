namespace ReportWriterWithAbstractFactory
{
    public interface IReportGenerator
    {
        IReportHeader GetReportHeader();

        IReportContent GetReportContent();

        IReportFooter GetReportFooter();
    }
}