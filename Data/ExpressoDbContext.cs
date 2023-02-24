using Expressoo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Expressoo.Data
{
    public class ExpressoDbContext:DbContext
    {
      public DbSet<Menu> Menus { get; set; }
      public DbSet<Reservation> Reservations { get; set; }        
      
    }
}