using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServerDemo.api.Model;
using Microsoft.EntityFrameworkCore;


namespace IdentityServerDemo.api.Data
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) :base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
    }
}
