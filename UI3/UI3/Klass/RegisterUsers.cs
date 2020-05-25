using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI3.Klass
{
    class RegisterUsers : DbContext
    {
        public RegisterUsers() : base("LoginUserEntities")
        {

        }
        public DbSet<DBreginuUsers> TbUsers { get; set; }


    }
}
