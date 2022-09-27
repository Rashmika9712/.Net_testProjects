using FastReportTesting;

string dataFile = "report.frx";
int[] counts = { 100000, 150000 };
List<List<Person>> testingData = new List<List<Person>>();

Console.WriteLine("Creating a random data sets for testing...");
for (int i = 0; i < counts.Length; i++)
{
    Data randomData = new Data();
    testingData.Add(randomData.GetPersons(counts[i]));
}
Console.WriteLine("Starting the test...");

Generate reportGenerator = new Generate(dataFile);

foreach (List<Person> data in testingData)
{
    var watch = System.Diagnostics.Stopwatch.StartNew();
    reportGenerator.GenerateReports(data, false);
    watch.Stop();
    Console.WriteLine("Time elapsed for the size of " + data.Count + " individuals: " + watch.Elapsed.ToString());
}
Console.WriteLine("End the test");
//waiting
Console.ReadLine();
