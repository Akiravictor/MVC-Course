using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AkiraMovies.Models
{
	public class MovieModels
	{
		public int Id { get; set; }
        [Required]
        [StringLength(255)]
		public string Name { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime AddedDate { get; set; }
        public int NumberInStock { get; set; }
    }
}