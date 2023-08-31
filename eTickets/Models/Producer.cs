using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }

        [Display(Name ="Profile")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Movie> Movies { get; set; }
    }
}
