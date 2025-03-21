using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class RepositoryContext(DbContextOptions<RepositoryContext> options) : DbContext(options)
{
    public DbSet<Company>? Companies { get; set; }

    public DbSet<Employee> Employees { get; set; }
}

