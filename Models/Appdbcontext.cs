using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;
using System;

namespace WebAppTASK.Models
{
    public class Appdbcontext:DbContext
    {
        public Appdbcontext()
        { }

        public Appdbcontext(DbContextOptions<Appdbcontext> options)
            : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source = (localdb)\ProjectModels;Initial Catalog = DemoData1; Integrated Security = True;");
            }
        }
        public DbSet<Customer> Customers { get; set; }
    }
     
}
