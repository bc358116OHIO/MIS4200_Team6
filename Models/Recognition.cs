using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class Recognition
    {
        [Key]
        public int RecognitionID { get; set; }

        public Guid ID { get; set; }

        public DateTime RecDate { get; set; }


        public Guid GiveID { get; set; }

        public Guid RecID { get; set; }

        [Display(Name = "Core Value recognized")]
        public CoreValue award { get; set; }

        public enum CoreValue
        {
            Culture = 1,
            Delivery_Excellence = 2,
            Greater_Good = 3,
            Innovation = 4,
            Integrity_and_Openness = 5,
            Live_a_Balanced_Life = 6,
            Stewardship = 7,
        }

        public string CoreValueExtra { get; set; }

        [ForeignKey("GiveID")]
        public virtual UserData userdatasGive { get; set; }

        [ForeignKey("RecID")]
        public virtual UserData userdatasRec { get; set; }

        

    }
}