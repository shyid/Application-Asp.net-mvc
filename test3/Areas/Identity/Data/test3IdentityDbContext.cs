using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using test3.Models;
namespace test3.Areas.Identity.Data;

public class test3IdentityDbContext : IdentityDbContext<IdentityUser>
{
    public test3IdentityDbContext(DbContextOptions<test3IdentityDbContext> options)
        : base(options)
    {
    }

   
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Actor_Movie>().HasKey(am => new{
            am.ActorId,
            am.MovieId 
        });
        builder.Entity<Actor_Movie>().HasOne(m=>m.movie).WithMany(am=>am.actor_Movies).HasForeignKey(m=>m.MovieId);
        base.OnModelCreating(builder);
        builder.Entity<Actor_Movie>().HasOne(m=>m.actor).WithMany(am=>am.actor_Movies).HasForeignKey(m=>m.ActorId);
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        // builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        builder.Seed();
        
    }


    public DbSet<Movie> Movies { get; set; }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Actor_Movie> Actors_Movies { get; set; }

    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> orderItems { get; set; }
    public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
}
    

