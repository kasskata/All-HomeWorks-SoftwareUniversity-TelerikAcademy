using System.Data.Entity;
using BlogSystem.Models;

namespace BlogSystem.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    class UserRepository : GenericRepository<ApplicationUser>
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
    }
}
