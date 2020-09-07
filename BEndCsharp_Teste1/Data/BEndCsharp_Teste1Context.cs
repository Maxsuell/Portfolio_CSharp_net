using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BEndCsharp_Teste1.Models
{
    public class BEndCsharp_Teste1Context : DbContext
    {
        public BEndCsharp_Teste1Context (DbContextOptions<BEndCsharp_Teste1Context> options)
            : base(options)
        {
        }

        public DbSet<BEndCsharp_Teste1.Models.Department> Department { get; set; }
    }
}
