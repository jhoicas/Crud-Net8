using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Product.Core.Services
{
   
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) : base(contextOptions)
        { }
     
    }
}
