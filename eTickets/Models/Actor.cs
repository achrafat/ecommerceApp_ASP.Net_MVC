using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        [Display(Name ="Profile")]
        [Required(ErrorMessage ="you must give the profile URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage ="you must enter your FullName")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="the name length must be between 3 and 50 ")]
        public string FullName { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
