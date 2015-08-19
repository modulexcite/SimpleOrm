﻿using ORM.Core;
using ORM.Models;

namespace ORM
{
    public class CustomDbContext : BaseDBContext
    {
        public CustomDbContext() : base("CustomConnectionString")
        {
        }

        public IDbSet<Customer> Customers { get; set; }

        public DbSet<Customer> Customers2 { get; set; }
    }
}
