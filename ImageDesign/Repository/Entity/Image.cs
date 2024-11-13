using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Entity
{
    public enum ImageCategory
    {
        Buildings,
        Landscapes,
        Animals,
        Food,
        Other
    }
    public class Image
    {
        public int Id { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Required]
        public string ImagePath { get; set; }
        public ImageCategory Category { get; set; }
    }
}
