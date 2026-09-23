using System.ComponentModel.DataAnnotations;

namespace Opgave.Models
{
    public class BookModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1, 5000)]
        public int Pages { get; set; }
        public BookGenre Genre { get; set; }
    }
    public enum BookGenre
    {
        Thriller,
        Horror,
        Slasher,
        Bodyhorror,
        Monster,
        Psychological,
        Supernatural
    }
}
