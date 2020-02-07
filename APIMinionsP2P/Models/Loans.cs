using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMinionsP2P.Models
{
    public class Loans
    {
        public int Id { get; set; }
        public int DeudorId { get; set; }
        public Users Deudor { get; set; }
        public int LenderId { get; set; }
        public Users Lender { get; set; }
        public int Tae { get; set; }
        public int Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime LeaseInception { get; set; }
        public int ContractPeriod{ get; set; }
    }
}
