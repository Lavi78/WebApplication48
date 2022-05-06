using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication48.Models
{
    public class Applicationdbcontext : DbContext
    {
        public Applicationdbcontext() : 
            base("Data Source=CHETUIWK988\\SQLSERVER;Initial Catalog=Data;Integrated Security=True;Pooling=False") { }

        public DbSet<Tiger> Tigers { get; set; }

    }
}