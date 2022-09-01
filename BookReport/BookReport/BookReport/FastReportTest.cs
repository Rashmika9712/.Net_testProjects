using FastReport.Export.Html;
using FastReport.Export.Image;
using FastReport;
using Newtonsoft.Json;

namespace BookReport
{
    public class FastReportTest
    {
        private static string outFolder = @"..\..\..\out\";
        private static string inFolder = @"..\..\..\in\";

        static Report GenerateReport()
        {

            Report report = new Report();

            report.Load(@"D:\Projects\.Net\test Projects\BookReport\BookReport\BookReport\in\Simple List");
            var json = JsonConvert.DeserializeObject<FamilyModel.Root>(File.ReadAllText(@"D:\Projects\.Net\test Projects\BookReport\BookReport\BookReport\in\familyList.json"));

            report.RegisterData(json.Family, "Family");

            return report;
        }

        static void Main(string[] args)
        {


            Report report;
            report = GenerateReport();

            // prepare the report
            report.Prepare();




            // export to image
            ImageExport image = new ImageExport();
            image.ImageFormat = ImageExportFormat.Jpeg;
            report.Export(image, $@"{outFolder}\report.jpg");



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
            report.Export(html, $@"{outFolder}\report.html");

            report.Dispose();

            Console.WriteLine("\nPrepared report and report exported as image have been saved into the 'out' folder.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();


        }
    }
}
