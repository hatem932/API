using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tabibFind.Models
{
    public class tabibFindContext : DbContext
    {
        public tabibFindContext(DbContextOptions<tabibFindContext> options)
            : base(options)
        {
        }

        public DbSet<tabibFind> TodoItems { get; set; }
    }

    }
}
