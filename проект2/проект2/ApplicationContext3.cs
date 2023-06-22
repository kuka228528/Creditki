using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace проект2
{
    class ApplicationContext3 : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public ApplicationContext3() : base("DefaultConnection3") { }
    }
}