using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trcakingapi.Models;

namespace trcakingapi.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
            :base(options)
        {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
