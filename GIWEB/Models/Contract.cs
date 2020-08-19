using GIWEB.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIWEB.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime DateIni { get; set; }
        public DateTime DateTer { get; set; }
        public double PercCommission { get; set; }
        public double Commission { get; set; }
        public ContractStatus Status { get; set; }
        public ICollection<Tenant> Tenant { get; set; }
        public ICollection<Owner> Owner { get; set; }

        public Contract()
        {
        }

        public Contract(int id, DateTime dateIni, DateTime dateTer, double percCommission, double commission, ContractStatus status)
        {
            Id = id;
            DateIni = dateIni;
            DateTer = dateTer;
            PercCommission = percCommission;
            Commission = commission;
            Status = status;
        }
    }
}
