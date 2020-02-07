using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMinionsP2P.Models
{
    public class Lender
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public ICollection<Loan> Loan { get; set; }
    }
}
