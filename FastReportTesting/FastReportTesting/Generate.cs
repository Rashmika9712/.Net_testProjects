using FastReport.Export.Html;
using FastReport;
using Newtonsoft.Json;
using System;

namespace FastReportTesting
{
    public class Generate
    {
        private Report report;
        private static string inputFolder = @"..\\..\\..\\in\\";
        private static string outputFolder = @"..\\..\\..\\out\\";
        private readonly string _reportFile;

        public Generate(string reportFile)
        {
            _reportFile = reportFile;
            report = new Report();
        }         
        public void GenerateReports(List<Person> persons, Boolean isSave)
        {
            report = new Report();
            report.Load(inputFolder + _reportFile);
            report.RegisterData(persons, "Persons");
            report.GetDataSource("Persons").Enabled = true;
            report.Prepare();
            string outFolder = outputFolder + persons.Count + "\\";

            if (!Directory.Exists(outFolder))
            {
                Directory.CreateDirectory(outFolder);
            }

            //export HTML
            HTMLExport html = new HTMLExport();
            html.EmbedPictures = true;
            // Enable all report pages in one html file
            html.SinglePage = false;
            // We don't need a subfolder for pictures and additional files
            html.SubFolder = false;
            // Enable layered HTML
            html.Layers = true;
            // Turn off the toolbar with navigation
            html.Navigator = false;

            if (isSave)
            {
                // save report in memory
                MemoryStream stream = new MemoryStream();
                report.Export(html, stream);
                report.Dispose();
                stream.Close();
            }
            else
            {
                // Save the report in html
                report.Export(html, $@"{outFolder}\report.html");
                report.Dispose();

            }
        }

    }
}
