﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string PRofilePictureUrl { get; set; }

        [Display(Name = "Full Name")]

        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full name must be between 3 to 500 chars")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]

        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}