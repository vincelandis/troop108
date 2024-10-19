using HistoryMarkupWizard.Models;

namespace HistoryMarkupWizard.Helpers;

public class FileWriter
{
    public FileWriter(string path)
    {
        Path = path;
        YearReports.Add(Utility.GetMockYearReport());
    }

    private readonly string Path;
    private readonly List<YearReport> YearReports = [];

    public void GenerateMarkup()
    {
        var reportsWritten = 0;
        Utility.WriteHostMessage($"Markup generator: do you want to proceed with markup generation? (count {YearReports.Count})");
        if (Utility.PromptYesNo())
        {
            reportsWritten = YearReports.Count;
        }

        Utility.WriteHostMessage($"{reportsWritten} YearReports were written to path '{Path}'. Press any key to return to main menu.");
        Console.ReadKey();
    }

    public void UpdateLocalStore()
    {
        Utility.WriteHostMessage($"Current year report count: ({YearReports.Count})");

        Console.Write("Enter next id to add:");
        var nextEntry = Console.ReadLine();
        int yearEntry;
        while (!int.TryParse(nextEntry, out yearEntry) || yearEntry < 1800 || yearEntry > DateTime.Now.Year)
        {
            Console.Write("Invalid year entered. Try again:");
            nextEntry = Console.ReadLine();
        }

        var yearReportById = YearReports.Find(o => o.Year == yearEntry);

        if (yearReportById == null)
        {
            yearReportById = new YearReport()
            {
                Year = yearEntry
            };
            YearReports.Add(yearReportById);
        }
    }
}
