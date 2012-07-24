namespace ReportWriterWIthoutAbstractFactory
{
    public class ReportWriter
    {
        public void GenerateReport(ReportOptions reportOptions)
        {
            if (reportOptions.ReportType == ReportType.HTML)
            {
                HTMLReportHeader htmlHeader = new HTMLReportHeader();
                htmlHeader.WriteHeaderDetails();

                HTMLReportContent htmlContent = new HTMLReportContent();
                htmlContent.WriteContents();

                HTMLReportFooter htmlFooter = new HTMLReportFooter();
                htmlFooter.WriteFooterDetails();
            }
            else if (reportOptions.ReportType == ReportType.Text)
            {
                TextReportHeader textReportHeader = new TextReportHeader();
                textReportHeader.WriteHeaderDetails();

                TextReportContent textReportContent = new TextReportContent();
                textReportContent.WriteContents();

                TextReportFooter textReportFooter = new TextReportFooter();
                textReportFooter.WriteFooterDetails();
            }
        }
    }
}