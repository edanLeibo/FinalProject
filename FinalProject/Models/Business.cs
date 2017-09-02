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
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int BusinessID { get; set; }

        [Display(Name = "Business Name")]
        [DataType(DataType.Text)]
        public string BusinessName { get; set; }

        [Display(Name = "Owner")]
        [DataType(DataType.Text)]
        public string Owner { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Street Address")]
        [DataType(DataType.Text)]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string Website { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Display(Name = "Rank")]
        public double AVGrank { get; set; }

        [Display(Name = "Category")]
        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

    }

}