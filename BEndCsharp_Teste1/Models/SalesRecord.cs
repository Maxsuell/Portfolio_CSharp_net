using System;
using BEndCsharp_Teste1.Models.Enum;

namespace BEndCsharp_Teste1.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double amount{ get; set; }
        public SaleStatus Status{ get; set; }
        public Seller Seller;

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            this.amount = amount;
            Status = status;
            Seller = seller;
        }

    }
}
