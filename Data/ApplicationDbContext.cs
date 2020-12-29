using System;
using System.Collections.Generic;
using System.Text;
using FloralShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FloralShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
       
     


    }
}
