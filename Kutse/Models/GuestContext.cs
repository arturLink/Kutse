using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kutse.Models
{
    public class GuestContext : DbContext
    {
        public DbSet<Guest> Guests { get;set; }
    }
}