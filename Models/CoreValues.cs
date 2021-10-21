using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class CoreValues
    {
        public int CoreValueID { get; set; }

        public string CoreValue { get; set; }

        public string CVDesc { get; set; }

        public ICollection<UserData>  userdata { get; set; }
    }
}