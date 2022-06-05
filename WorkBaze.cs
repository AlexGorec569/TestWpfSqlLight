using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Test_Wpf2_SQL
{
    class WorkBaze : DbContext
    {

        public DbSet<Phone> Phones { get; set; } 

        public WorkBaze() : base("DefaultConnection") { }

    }
}
