using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Text;

namespace Models
{
    public class UserLoginEntity : DbContext
    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<UserInfo> Userinformation { get; set; }
    }

  
}