using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GIWEB.Models
{
    public class Propertie
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string N { get; set; }
        public string Neighborhood { get; set; }
        public string Cep { get; set; }
        public string City { get; set; }
        public string Uf { get; set; }
        public double RentValue { get; set; }
        public ICollection<Owner> Owner { get; set; } = new List<Owner>();

        public Propertie()
        {
        }

        public Propertie(int id, string address, string n, string neighborhood, string cep, string city, string uf, double rentValue)
        {
            Id = id;
            Address = address;
            N = n;
            Neighborhood = neighborhood;
            Cep = cep;
            City = city;
            Uf = uf;
            RentValue = rentValue;
        }
    }
}
