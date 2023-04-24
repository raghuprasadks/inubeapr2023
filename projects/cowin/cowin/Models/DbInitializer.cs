using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cowin.Models
{
    public class DbInitializer
    {
        public static void Initialize(CowinContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
