using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace UI3.Klass
{
    class ProgrammContext : DbContext
    {
        public ProgrammContext() : base ("MaslovEntities")
        {

        }
        public DbSet<DB> Sheet1_ { get; set; }




    }
}
