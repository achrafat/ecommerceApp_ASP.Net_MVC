using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Display(Name ="MovieName")]
        public string MovieName { get; set; }

        [Display(Name = "Description")]
        public string MovieDescription { get; set; }

        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }

        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Logo")]
        public string ImageURL { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }

        //cinema
        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; }

        //Producer
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        public Producer producer { get; set; }


    }
}
