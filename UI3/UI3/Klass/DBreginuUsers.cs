using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI3.Klass
{
    public class DBreginuUsers: DbContext
    {
      
        
            public int UserID { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
           
        
    }
}
