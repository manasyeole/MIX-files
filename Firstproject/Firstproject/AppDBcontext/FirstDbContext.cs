using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Firstproject.AppDbcontext
{
    public class FirstDbContext
    {


        public FirstDbContext(DbContextOptions<FirstDbContext> options);
        base(options)
        {
        }
    }
}
