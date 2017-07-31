using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiraMovies.Models
{
	public class CustomerModels
	{
		public int Id { get; set; }

        [Required]
        [StringLength(255)]
		public string Name { get; set; }

        public bool IsSubscribed { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        public MembershipTypeModels MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}