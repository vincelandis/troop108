using HistoryMarkupWizard.Models;

namespace HistoryMarkupWizard.Helpers;

public static class MarkupBuilder
{
    public static string FontFamily => "font-family: Arial, Helvetica, sans-serif;";
    public static string TextStyleHeader => "font-size: xx-large;";
    public static string TextStyleBody => "font-size: large; text-align: justify;";
    public static string TextStyleSubtext => "font-size: large;";
    public static string GenerateMarkupByYear(YearReport year)
    {
        var advancement = GenerateAdvancementMarkup(year.AdvancementReport);
        var camping = GenerateCampingMarkup(year.CampingReport);
        var explorer = GenerateExplorerMarkup(year.ExplorerReport);
        var misc = GenerateMiscMarkup(year.MiscReport);

        return @$"
            <div style=""{FontFamily} text-align: center;"">
                {advancement}
                {camping}
                {explorer}
                {misc}
            </div>
        ";
    }

    private static string GenerateAdvancementMarkup(AdvancementReport? report)
    {
        throw new NotImplementedException();
    }

    private static string GenerateCampingMarkup(CampingReport? report)
    {
        throw new NotImplementedException();
    }

    private static string GenerateExplorerMarkup(ExplorerReport? report)
    {
        if (report == null) return string.Empty;

        var markup = string.Empty;
        if (!string.IsNullOrWhiteSpace(report.OpeningComment))
        {
            markup += $"<p>{TextStyleHeader}><strong>{ExplorerReport.AlternateTitle}</strong></p>";
            markup += $"<p>{TextStyleBody}>{report.OpeningComment}</p>";
        }
        if (!string.IsNullOrWhiteSpace(report.ClosingComment))
        {
            markup += $"<p>{TextStyleBody}>{report.ClosingComment}</p>";
        }
        if (!string.IsNullOrWhiteSpace(report.SubmittedBy))
        {
            markup += $"<p>{TextStyleSubtext}><strong>{report.SubmittedBy}</strong></p>";
        }

        return markup;
    }

    private static string GenerateMiscMarkup(MiscReport? report)
    {
        if (report == null) return string.Empty;

        var markup = string.Empty;
        if (!string.IsNullOrWhiteSpace(report.Header))
        {
            markup += $"<p>{TextStyleHeader}><strong>{report.Header}</strong></p>";
        }
        if (!string.IsNullOrWhiteSpace(report.OpeningComment))
        {
            markup += $"<p>{TextStyleBody}>{report.OpeningComment}</p>";
        }
        if (!string.IsNullOrWhiteSpace(report.ClosingComment))
        {
            markup += $"<p>{TextStyleBody}>{report.ClosingComment}</p>";
        }
        if (!string.IsNullOrWhiteSpace(report.SubmittedBy))
        {
            markup += $"<p>{TextStyleSubtext}><strong>{report.SubmittedBy}</strong></p>";
        }

        return markup;
    }

    // <p style="font-size: xx-large; ">
    //     <strong>1959 Camping Report</strong>
    // </p>
    // <p style="font-size: large; text-align: justify;">
    //     During 1959 we were very fortunate to have participated in many camping outdoor activities. Our ranks include
    //     boys from all walks of life. We had 34 boys participating in our camping experiences, with a total of 415 days
    //     of camping, an average of 12.2 days per boy.
    // </p>
    // <p style="font-size: large; text-align: justify;">
    //     Scanning our 1959 Camping log, we note that we spent a week of fun and camping at Resica Falls in the Pocono
    //     Mountains. Other camping trips included hikes to Mill Hill, pre-camporee at our cabin in May, the District
    //     camporee at Camp Delmont in October and four weekends at out cabin - one each in March, April, June and
    //     November.
    //     In September a colorful camping trip to Potter County took us 600 miles from home base, making trips to the Ice
    //     Mine in Coudersport and visiting the Grand Canyon at Wellsboro. On overnight camping trips boys conducted
    //     themselves according to Scouting tradition…cooking out, trailing, doing wood lore, compass work, campcraft, etc.
    //     For our year-end camping experience, we had our annual Christmas dinner and party at our cabin. This has been
    //     our camping log for 1959, an exciting, interesting and enjoyable one. Four of our Explorers Scouts also had the
    //     pleasure of the scenic wonders of Philmont Scout Ranch in New Mexico, a true scouting trip in every sense. These
    //     boys were Bruce Heimbach, Gerald Schantz, Paul Shellaway and John Rosanski.
    // </p>
    // <p style="font-size: large;">
    //     <strong>Submitted by: Paul Sames, Troop Camping Chairman</strong>
    // </p>
}