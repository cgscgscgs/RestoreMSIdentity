/*  date            developer               changes
 *  2/11/2025        celina                 copied SiteOverviewModel.cs, step 1 of connecting to azure sql database
 * 
 * 
 * 
 * */



using System.ComponentModel.DataAnnotations;    



namespace RestoreMSIdentity.Models
{
           
    // This class is a model for the site overview page.
    // It contains properties that represent the data displayed on the page.
    public class SiteOverviewModelCopy
    {

        // The [Display] attribute specifies the display name for a property.
        // The Name property is displayed as "Site Name" on the page.
        public int Id { get; set; } // unique identifier, primary key for the site

        [Display(Name = "Site Name")]
        public string Name { get; set; } // name of the site

        public string OwnershipType { get; set; } // public OR private
        public string City { get; set; } // city where the site is located

        public string Status { get; set; } // active, maintainence

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; } // approximate date work began at this site

    }
}
