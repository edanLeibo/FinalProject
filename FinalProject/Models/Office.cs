using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace FinalProject.Models
{
    public class Office
    {
        public int OfficeID { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "Street")]
        [DataType(DataType.Text)]
        public string Street { get; set; }

        [Display(Name = "House Number")]
        [DataType(DataType.Text)]
        public string HouseNumber { get; set; }

        [Display(Name = "Latitude")]
        [DataType(DataType.Text)]
        public double Latitude { get; set; }

        [Display(Name = "Longitude")]
        [DataType(DataType.Text)]
        public double Longitude { get; set; }

        [Display(Name = "Manager")]
        [DataType(DataType.Text)]
        public string Manager { get; set; }

    }

}
