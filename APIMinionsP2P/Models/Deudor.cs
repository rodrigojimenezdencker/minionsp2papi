using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIMinionsP2P.Models
{
    public class Deudor
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string DNI { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public ICollection<Loan> Loan { get; set; }

    }
}
