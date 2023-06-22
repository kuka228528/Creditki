using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace проект2
{
    class ApplicationContext2 : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public ApplicationContext2() : base("DefaultConnection2") { }
    }
}