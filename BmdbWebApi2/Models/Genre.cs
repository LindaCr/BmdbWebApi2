using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi2.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [StringLength(30), Required]
        public string Name { get; set; }

    }
}
