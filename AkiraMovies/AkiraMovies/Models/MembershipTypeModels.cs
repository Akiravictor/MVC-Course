using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkiraMovies.Models
{
    public class MembershipTypeModels
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }

	public enum MembershipTypeEnum
	{
		Unknow = 0,
		PayAsYouGo = 1,
		Monthly = 2,
		Quarterly = 3,
		Anually = 4
	}
}