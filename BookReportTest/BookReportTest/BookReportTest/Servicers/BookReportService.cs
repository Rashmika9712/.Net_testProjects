namespace BookReportTest.Servicers
{
    public class BookReportService : IBookReportService
    {
        public string Create(string lang, string reportName)
        {
            return "{count = 23, reportid = 417o4c1r-d297-4b4f-a19d-83001ef24471d }";
        }

        public string GetLast(string reportName)
        {
            return "{count = 10, reportid = b1754c14-d296-4b0f-a09a-030017f4461f }";
        }

        public string GetPage(int reportId, int pageNumber)
        {
            string fileName = @"D:\Embla Family tree\ftwebcore\FT.ReportPublisher\Reports\Html\allPersonReport\report" + pageNumber;

            string foundHTMl = File.ReadAllText(fileName);

            return foundHTMl;
        }

        public string GetReport(int reportId)
        {
            return "{count = 15, reportid = 417o4c1r-d297-4b4f-a19d-83001ef24471d, isGenerating = true }";
        }
    }
}
