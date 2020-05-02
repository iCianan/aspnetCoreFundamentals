using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace core_api
{
    public class ProductDetails
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string Image { get; set; }

        public string Description { get; set; }
        public string Size { get; set; }

        [Required]
        public int quantityInStock { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public Guid CategoryId { get; set; }
    }
}
