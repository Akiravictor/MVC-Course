using AkiraMovies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AkiraMovies.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipTypeModels> MembershipTypes { get; set; }
        public CustomerModels Customer { get; set; }
    }
}