using Microsoft.EntityFrameworkCore;
using ProjectVs.Models;

public class MyDbContext : DbContext
{
    private readonly IConfiguration _configuration;

    public MyDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("RegisterConnection"));
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ReadingConnection"));
        
    }
}

namespace ProjectVs.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
    }
}