using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EX5.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Display(Name = "Author")]
        [DataType(DataType.Text)]
        public string Author { get; set; }

        [Display(Name = "Description")]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Display(Name = "Score")]
        [DataType(DataType.Text)]
        public int Score { get; set; }

        [Display(Name = "BusinessID")]
        public int BusinessID { get; set; }

        public virtual Business Business { get; set; }
    }
}