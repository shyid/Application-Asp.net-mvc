using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ticket.Models;
namespace ticket.Areas.Identity.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
        builder.Seed();
    }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<MemberShipType> MemberShipType { get; set; }
    public DbSet<Movie> Movie { get; set; }
}
public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>{
    public void Configure(EntityTypeBuilder<ApplicationUser> builder){
  
        builder.Property(x=> x.FirstName).HasMaxLength(255);
        builder.Property(x=> x.LastName).HasMaxLength(255);
    }  
    
}
