using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EX5.Models
{
    public class User : IComparable<User>
    {
       // [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int UserID { get; set; }

        [Display(Name = "FirstName")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }


        [Display(Name = "LastName")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Gender")]
        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [Display(Name = "BirthDate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public int CompareTo(User other)
        {
            if (this.FirstName == other.FirstName)
                return 0;
            else return -1;
        }

        public void copy(User m)
        {
            FirstName = m.FirstName;
            LastName = m.LastName;
            Gender = m.Gender;
            BirthDate = m.BirthDate;
        }

    }

}