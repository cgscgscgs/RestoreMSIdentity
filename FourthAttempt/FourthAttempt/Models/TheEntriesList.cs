using System.ComponentModel.DataAnnotations;

namespace FourthAttempt.Models
{
    public class TheEntriesList
    {
        [Key] public int SiteEntryID { get; set; }

        public string SiteName { get; set; }
        public string AuthorFirst { get; set; }
        public string AuthorLast { get; set; }
        public string AuthorRole { get; set; }
        public string? EntrySummary { get; set; }
    }
}
