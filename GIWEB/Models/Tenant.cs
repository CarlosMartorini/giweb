using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIWEB.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Tel { get; set; }
        public string Cel { get; set; }
        public string  Email { get; set; }
        public string Profession { get; set; }
        public string Employer { get; set; }
        public string TelEmployer { get; set; }

        public Tenant()
        {
        }

        public Tenant(int id, string name, string cpf, string rg, string tel, string cel, string email, string profession, string employer, string telEmployer)
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Rg = rg;
            Tel = tel;
            Cel = cel;
            Email = email;
            Profession = profession;
            Employer = employer;
            TelEmployer = telEmployer;
        }
    }
}
