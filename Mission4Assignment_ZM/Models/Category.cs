using System;
using System.ComponentModel.DataAnnotations;

namespace Mission4Assignment_ZM.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Choose the category")]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
