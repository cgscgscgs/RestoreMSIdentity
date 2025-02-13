/*
 *  Kari Stephenson 
 *                  Added dataannotations using stmt, key and required tags 2/13
 *                  added 'required' in 'public required string' to address Name, Desc etc error 2/13
 *
 */


using System.ComponentModel.DataAnnotations;

namespace RestoreMSIdentity.Models

{
    public class LandingPageModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        [Required]
        public required string Description { get; set; }
        [Required]
        public required string Location { get; set; }
        [Required]
        public required string ImageUrl { get; set; }
    }


    // Example: for /Home/LandingPage in URL, would need controller named Home and action named LandingPage
}
