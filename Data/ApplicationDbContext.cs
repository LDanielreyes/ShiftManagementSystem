using Microsoft.EntityFrameworkCore;
using SaludLinux.Models;
using ShiftManagementSystem.Data.Entities;
using ShiftManagementSystem.Models;

namespace ShiftManagementSystem.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Admin> Admins{get;set;}
    public DbSet<Affiliate> Affiliates{get;set;}
    public DbSet<Card>Cards{get;set;}
    public DbSet<Employee>Employees{get;set;}
    public DbSet<ServiceHistory>ServiceHistorys{get;set;}
    public DbSet<Ticket>Tickets{get;set;}
    public DbSet<TicketRegister>TicketRegisters{get;set;}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Affiliate>().HasBaseType<Person>();
        modelBuilder.Entity<Employee>().HasBaseType<Person>();
        base.OnModelCreating(modelBuilder);
    }
}