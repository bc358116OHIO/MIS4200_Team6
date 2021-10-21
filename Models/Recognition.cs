﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class Recognition
    {
        [Key]
        public int RecognitionID { get; set; }
        public int CoreValueID { get; set; }

        public Guid ID { get; set; }

        public DateTime RecDate { get; set; }

        public int GiveID { get; set; }

        public int RecID { get; set; }

        public virtual UserData userdatas { get; set; }

        public virtual CoreValues corevalues { get; set; }
    }
}