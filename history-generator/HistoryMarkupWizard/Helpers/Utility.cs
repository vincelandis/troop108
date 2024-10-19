using HistoryMarkupWizard.Models;

namespace HistoryMarkupWizard.Helpers;

public static class Utility
{
    public static void WriteHostMessage(string message)
    {
        Console.Clear();
        Console.WriteLine(
            new string('=', 75) + "\n" +
            message + "\n" +
            new string('=', 75) + "\n"
        );
    }

    public static bool PromptYesNo()
    {
        Console.Write("(Y/N):");
        var answer = Console.ReadLine() ?? "N";
        return answer.Equals("Y", StringComparison.CurrentCultureIgnoreCase);
    }

    public static YearReport GetMockYearReport() => new()
    {
        Year = 2024,
        AdvancementReport = new()
        {
            OpeningComment = "AdvancementReport Opening Comment",
            Ranks = [
                new() {
                    RankId = 0,
                    NameList = "Vince Landis,Vince Landis"
                }
            ],
            ClosingComment = "AdvancementReport Closing Comment",
            SubmittedBy = "Vince Landis"
        },
        CampingReport = new()
        {
            OpeningComment = "CampingReport Opening Comment",
            Trips = [
                new() {
                    MonthId = 0,
                    ActivityText = "Camping was done this month"
                }
            ],
            ClosingComment = "CampingReport Closing Comment",
            SubmittedBy = "Vince Landis"
        },
        ExplorerReport = new()
        {
            OpeningComment = "Explorer Post Opening Comment",
            ClosingComment = "Explorer Post Closing Comment",
            SubmittedBy = "Vince Landis"
        },
        MiscReport = new()
        {
            OpeningComment = "Misc Report Opening Comment",
            ClosingComment = "Misc Report Closing Comment",
            SubmittedBy = "Vince Landis"
        }
    };
}
