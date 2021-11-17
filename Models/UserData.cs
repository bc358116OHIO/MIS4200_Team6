using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class UserData
    {

        [Key]
        [Display(Name = "Recipient")]
        public Guid ID { get; set; }

        [Display(Name= "First Name")]
        [Required]
        [MaxLength(30)]

        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MaxLength(30)]

        public string lastName { get; set; }

        [Display(Name = "Full Name")]
        [Required]


        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }

        }

        [Display(Name = "Office Location")]
        [Required]
        [MaxLength(30)]

        public string officeLocation { get; set; }

        [Display(Name = "Position")]
        [Required]
        [MaxLength(30)]

        public string position { get; set; }

        [Display(Name = "Start Date")]

        public DateTime startDate { get; set; }

        [ForeignKey("RecID")]
        public ICollection<Recognition> recognitionsRec { get; set; }

        [ForeignKey("GiveID")]
        public ICollection<Recognition> recognitionsGive { get; set; }

    }
}