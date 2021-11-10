﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MIS4200_Team6.Models
{

    public class CoreValues
    {
        [Key]

        [Display(Name = "Core Value")]
        public int CoreValueID { get; set; }

        [Display (Name ="Core Value")]

        public string CoreValue { get; set; }

        public string CVDesc { get; set; }

        public ICollection<Recognition>  recognitions { get; set; }


    }
}