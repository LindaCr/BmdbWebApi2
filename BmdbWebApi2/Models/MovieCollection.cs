using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BmdbWebApi2.Models
{
    public class MovieCollection
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        [Column(TypeName="decimal(11,2)")]
        public decimal PurchasePrice { get; set; }

    }
}
