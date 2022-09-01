using FastReport;
using FastReport.Export.Html;
using FastReport.Export.Image;
using Newtonsoft.Json;
using sample_Fast_Report;
using System;
using System.IO;

namespace DataFromDataSet
{
    class Program
    {
        private static string outFolder = @"..\..\..\out\";
        private static string inFolder = @"..\..\..\in\";

        static Program()
        {
            inFolder = Utils.FindDirectory("in");
            outFolder = Directory.GetParent(inFolder).FullName + "\\out";
        }

        static Report GenerateReport()
        {
         
            Report report = new Report();

            report.Load(@"D:\Embla\Book Report\old Code\EmblaFtReport\sample_Fast_Report\sample_Fast_Report\in\sample.frx");
            var json = JsonConvert.DeserializeObject<FamilyModel.Root>(File.ReadAllText(@"D:\Embla\Book Report\old Code\EmblaFtReport\sample_Fast_Report\sample_Fast_Report\in\familyList.json"));

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
