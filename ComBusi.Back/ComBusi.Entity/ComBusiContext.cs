
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

  }
}
