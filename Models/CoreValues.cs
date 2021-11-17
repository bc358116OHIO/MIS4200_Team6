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
        public int CVID { get; set; }

        public string CV { get; set; }

        public string CVD { get; set; }
    }
}