using AkiraMovies.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiraMovies.DataTransferObject
{
    public class CustomerDTO
    {

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribed { get; set; }

        //[MembershipTypeValidation]
        public DateTime? Birthdate { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}