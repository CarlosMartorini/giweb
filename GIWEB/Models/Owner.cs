using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GIWEB.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Owner()
        {
        }

        public Owner(int id, string name, string cpf, string rg, string tel, string cel, string email, string address)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Rg = rg;
            Tel = tel;
            Cel = cel;
            Email = email;
            Address = address;
        }
    }
}
