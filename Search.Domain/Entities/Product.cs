using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Domain.Entities
{
    public class Product
    {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
            public double Price { get; set; }
            public string ProductDetails { get; set; }
    }
}
