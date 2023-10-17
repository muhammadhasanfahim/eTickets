﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID { get; set; }

        [Display(Name = "Profile Picture")]
        public string PRofilePictureUrl { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Realtionships
        public List<Movie> Movies { get; set; }
    }
}
