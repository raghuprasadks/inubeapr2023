using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cowinnew.Models
{
    public class DBInitializer
    {
        public static void Initialize(CowinContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
