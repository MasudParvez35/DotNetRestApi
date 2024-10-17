using DotNetRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetRestApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Post> Posts { get; set; }
}
