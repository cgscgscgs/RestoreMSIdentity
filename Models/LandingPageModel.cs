namespace RestoreMSIdentity.Models
{
    public class LandingPageModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }
    }


    // Example: for /Home/LandingPage in URL, would need controller named Home and action named LandingPage
}
