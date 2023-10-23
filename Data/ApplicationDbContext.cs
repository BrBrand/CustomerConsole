using CustomerConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole.Data
{
    internal class ApplicationDbContext
    {
    }
}

public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=CustomersData;TrustServerCertificate=True;Trusted_Connection=true;MultipleActiveResultSets=true");
    }
}