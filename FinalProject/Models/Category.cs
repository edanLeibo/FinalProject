using EX5.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.Models
{
    public class Category
    {
        [Display(Name = "Category ID")]
        public int CategoryID { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [DataType(DataType.Text)]
        public string CategoryName { get; set; }

        public virtual ICollection<Business> Businesses { get; set; }
    }
}