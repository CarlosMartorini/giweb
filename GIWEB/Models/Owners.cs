using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GIWEB.Models
{
    public class Owners
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
