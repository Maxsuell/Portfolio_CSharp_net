using System;
using System.Collections.Generic;
using System.Linq;

namespace BEndCsharp_Teste1.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller (Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSeles(DateTime initial, DateTime final)
        {
            return Sellers.Sum(Seller => Seller.TotalSales(initial, final));
        }
    }
}
