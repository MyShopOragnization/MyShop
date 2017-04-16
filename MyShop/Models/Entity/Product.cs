using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyShop.Models.Entity
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [MaxLength(40)]
        public string ProductName { get; set; }

        public Nullable<int> CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category category { get; set; }
    }
}