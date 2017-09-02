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
        public int month { get; set; }
        public int ReviewCount { get; set; }
        public ReviewCount ReviewCountData { get; set; }
        public string Title { get; set; }
        public string CountTitle { get; set; }
    }



    public class ReviewCount
    {
        public string Month { get; set; }
        public string Count { get; set; }

    }
}