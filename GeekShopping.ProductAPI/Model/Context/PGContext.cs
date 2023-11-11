﻿using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductAPI.Model.Context
{
    public class PGContext : DbContext
    {
        public PGContext() {}
        public PGContext(DbContextOptions<PGContext> options) : base(options) {}
        public DbSet<Product> Products { get; set;}
    }
}
