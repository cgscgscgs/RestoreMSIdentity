using Microsoft.AspNetCore.Mvc;

namespace RestoreMSIdentity.Models
{
    public class SiteModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

}
