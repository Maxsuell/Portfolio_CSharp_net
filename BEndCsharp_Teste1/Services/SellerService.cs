using BEndCsharp_Teste1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BEndCsharp_Teste1.Services
{
    public class SellerService
    {
        private BEndCsharp_Teste1Context _context;

        public SellerService(BEndCsharp_Teste1Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }
    }
}
