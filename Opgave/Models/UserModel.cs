using System.ComponentModel.DataAnnotations;

namespace Opgave.Models
{
    public class UserModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
