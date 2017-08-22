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
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int ID { get; set; }

        [Display(Name = "BusinessName")]
        [DataType(DataType.Text)]
        public string BusinessName { get; set; }

        [Display(Name = "Owner")]
        [DataType(DataType.Text)]
        public string Owner { get; set; }

        [Display(Name = "PhoneNumber")]
        [DataType(DataType.Text)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string Website { get; set; }

        [Display(Name = "TextContent")]
        [DataType(DataType.Text)]
        public string TextContent { get; set; }

        [Display(Name = "Photo")]
        public string Photo { get; set; }

        [Display(Name = "Video")]
        public string Video { get; set; }

        public virtual ICollection<Rank> Ranks { get; set; }

    }

    public class BusinessContext : DbContext
    {
        public DbSet<Business> DBBusiness { get; set; }

    }
}