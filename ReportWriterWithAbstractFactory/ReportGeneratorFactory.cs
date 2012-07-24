namespace ReportWriterWithAbstractFactory
{
    public class ReportGeneratorFactory
    {
        public static IReportGenerator GetReportGenerator(ReportType reportType)
        {
            switch (reportType)
            {
                case ReportType.HTML:
                    return new HTMLReportGenerator();
                case ReportType.Text:
                    return new TextReportGenerator();
            }
        }
    }
}