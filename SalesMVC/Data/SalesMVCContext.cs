using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMVC.Models;

namespace SalesMVC.Data
{
    public class SalesMVCContext : DbContext
    {
        public DbSet<SalesMVC.Models.Customer> Customers { get; set; }
        public DbSet<SalesMVC.Models.Order> Orders { get; set; }
        public DbSet<SalesMVC.Models.Orderline> Orderlines { get; set; }

        public SalesMVCContext (DbContextOptions<SalesMVCContext> options)
            : base(options)
        {
        }
        //fluent api that makes columns unique
        protected override void OnModelCreating(ModelBuilder builder) {

        }
        //fluent api that makes columns unique
        public DbSet<SalesMVC.Models.Order> Order { get; set; }

    }
}
