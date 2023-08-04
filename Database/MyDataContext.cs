using Microsoft.EntityFrameworkCore;
using Minimal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimal.Database
{
    public class MyDataContext : DbContext
    {
        public MyDataContext(DbContextOptions<MyDataContext> options)
       : base(options) { }

        public DbSet<Student> Students => Set<Student>();
    }
}
