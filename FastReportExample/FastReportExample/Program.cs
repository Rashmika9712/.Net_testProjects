
using FastReportExample;

Generate report = new Generate("Person.json", "report.frx");
report.LoadFiles();
report.generateReports();