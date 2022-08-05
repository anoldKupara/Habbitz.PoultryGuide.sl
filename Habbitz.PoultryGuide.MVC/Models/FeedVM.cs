using System.ComponentModel.DataAnnotations;

namespace Habbitz.PoultryGuide.MVC.Models
{
    public class FeedVM : CreateFeedVM
    {
        public int Id { get; set; }
    }

    public class CreateFeedVM
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Purpose { get; set; }
    }
}
