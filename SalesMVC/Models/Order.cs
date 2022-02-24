using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SalesMVC.Models {
    public class Order {
        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Description { get; set; }
        [Required, Column(TypeName = "decimal(11,2")]
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public IEnumerable<Orderline> OrderLines { get; set; }
    }
}
