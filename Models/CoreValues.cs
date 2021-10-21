using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class CoreValues
    {
        [Key]
        public int CoreValueID { get; set; }

        public string CoreValue { get; set; }

        public string CVDesc { get; set; }

        public ICollection<Recognition>  recognitions { get; set; }


    }
}