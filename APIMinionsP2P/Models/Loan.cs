using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIMinionsP2P.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public int DeudorId { get; set; }
        public Deudor Deudor { get; set; }
        public int LenderId { get; set; }
        public Lender Lender { get; set; }
        public int Amount { get; set; }
        public int Tae { get; set; }
        public int ContractPeriod { get; set; }

        [DataType(DataType.Date)]
        public DateTime LeaseInception { get; set; }
    }
}
