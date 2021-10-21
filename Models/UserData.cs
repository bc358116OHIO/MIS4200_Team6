using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Team6.Models
{
    public class UserData
    {

        [Key]
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

        public ICollection<Recognition> recognitions { get; set; }

    }
}