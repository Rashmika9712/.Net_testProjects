using FastReport;
using FastReport.Export.Html;
using Newtonsoft.Json;

namespace FastReportExample
{
    public class Generate
    {
        private Report report;
        private string _jsonFile;
        private static string inputFolder = @"..\\..\\..\\in\\";
        private static string outputFolder = @"..\\..\\..\\out\\";
        private readonly string _reportFile;
        private List<Person> personList;

        public Generate(string jsonFile, string reportFile)
        {
            _reportFile = reportFile;
            _jsonFile = jsonFile;
            report = new Report();
            personList = new List<Person>();
        }

        public void LoadFiles()
        {
            personList = JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(inputFolder + _jsonFile));
            report.Load(inputFolder + _reportFile);
            report.RegisterData(personList, "Persons");
            report.GetDataSource("Persons").Enabled = true;
        }

        public void generateReports()
        {
            report.Prepare();
            // export to image
            /*ImageExport image = new ImageExport();
            image.ImageFormat = ImageExportFormat.Jpeg;
            report.Export(image, $@"{outFolder}\report.jpg");*/

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

            // Save the report in html
            report.Export(html, $@"{outputFolder}report.html");
            report.Dispose();
        }

    }
}
