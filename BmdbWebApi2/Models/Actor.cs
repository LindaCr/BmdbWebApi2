using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi2.Models
{
    public class Actors
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Firstname { get; set; }
        [StringLength(30), Required]
        public string Lastname { get; set; }
        [StringLength(1), Required]
        public string Gender { get; set; }
        public DateTime Birthdate { get; set; }

    }
}
