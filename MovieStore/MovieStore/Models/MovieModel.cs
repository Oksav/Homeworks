using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Models
{
    public class MovieModel
    {
        public int ID { get; set; }
        [Required]
        public string MovieName { get; set; }
        public int Year { get; set; }
        public string Length { get; set; }
        [Required]
        [Range(5,10, ErrorMessage ="Enter price range between 5-10 EUR.")]
        public int TicketPrice { get; set; }

    }
}
