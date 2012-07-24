namespace ReportWriterWithAbstractFactory
{
    public class ReportWriter
    {
        public void GenerateReport(ReportOptions reportOptions)
        {
            IReportGenerator reportGenerator = ReportGeneratorFactory.GetReportGenerator(reportOptions.ReportType);

            reportGenerator.GetReportHeader().WriteHeaderDetails();

            reportGenerator.GetReportContent().WriteContents();

            reportGenerator.GetReportFooter().WriteFooterDetails();
        }
    }
}