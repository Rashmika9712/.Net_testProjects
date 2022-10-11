namespace BookReportTest.Servicers
{
    public interface IBookReportService
    {
        public string GetLast(string reportName);
        public string Create(string lang, string reportName);
        public string GetPage(int reportId, int pageNumber);
        public string GetReport(int reportId);
    }
}
