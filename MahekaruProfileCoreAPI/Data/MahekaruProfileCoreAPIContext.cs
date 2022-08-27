using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MahekaruProfileCoreAPI.Models;

namespace MahekaruProfileCoreAPI.Data
{
    public class MahekaruProfileCoreAPIContext : DbContext
    {
        public MahekaruProfileCoreAPIContext (DbContextOptions<MahekaruProfileCoreAPIContext> options)
            : base(options)
        {
        }

        public DbSet<MahekaruProfileCoreAPI.Models.Profile> Profile { get; set; }
    }
}
