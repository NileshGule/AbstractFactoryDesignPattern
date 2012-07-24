using System;

namespace ReportWriterWithAbstractFactory
{
    public class TextReportGenerator : IReportGenerator
    {
        public IReportHeader GetReportHeader()
        {
            throw new NotImplementedException();
        }

        public IReportContent GetReportContent()
        {
            throw new NotImplementedException();
        }

        public IReportFooter GetReportFooter()
        {
            throw new NotImplementedException();
        }
    }
}