using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FinalProject.ViewModel
{
    public class ReviewDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; internal set; }

        public int ReviewCount { get; set; }

    }
}