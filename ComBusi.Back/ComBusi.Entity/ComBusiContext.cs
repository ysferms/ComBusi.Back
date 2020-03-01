
using Microsoft.EntityFrameworkCore;
using System;

namespace ComBusi.Entity
{
  public class ComBusiContext : DbContext
  {
    public ComBusiContext(DbContextOptions<ComBusiContext> options)

 : base(options)

    { }


    public DbSet<Company> Companies { get; set; }
    public DbSet<Branch> Branches { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<CompanyInformation> CompanyInformations { get; set; }
    public DbSet<Adress> Adresses { get; set; }
    public DbSet<Test> Tests { get; set; }
  }
}
