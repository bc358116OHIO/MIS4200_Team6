using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class UserData
    {
        public Guid ID { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }

        }

        public string officeLocation { get; set; }

        public string position { get; set; }

        public DateTime startDate { get; set; }


    }
}