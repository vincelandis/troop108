namespace HistoryMarkupWizard.Models;

public class YearReport
{
    /// <summary>
    /// The year
    /// </summary>
    public int Year { get; set; }
    public AdvancementReport? AdvancementReport { get; set; }
    public CampingReport? CampingReport { get; set; }
    public ExplorerReport? ExplorerReport { get; set; }
    public MiscReport? MiscReport { get; set; }
}
