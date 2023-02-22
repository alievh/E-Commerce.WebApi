using E_Commerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions options) : base(options) { }

	public virtual DbSet<Product> Products { get; set; }
	public virtual DbSet<Order> Orders { get; set; }
	public virtual DbSet<Costumer> Costumers { get; set; }
}
