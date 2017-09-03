using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EX5.Models
{
    public class Business 
    {
        public int BusinessID { get; set; }

        [Required]
        [Display(Name = "Business Name")]
        [DataType(DataType.Text)]
        public string BusinessName { get; set; }

        [Required]
        [Display(Name = "Owner")]
        [DataType(DataType.Text)]
        public string Owner { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Required]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Rank")]
        public double AVGrank { get; set; }

        [Required]
        [Display(Name = "CategoryID")]
        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }

}