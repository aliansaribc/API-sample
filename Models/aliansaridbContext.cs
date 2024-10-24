using Microsoft.EntityFrameworkCore;

namespace reactAPI.Models
{
    public partial class aliansaridbContext : DbContext
    {
        public aliansaridbContext(){}
        public aliansaridbContext(DbContextOptions<aliansaridbContext> options) : base(options){}
        public virtual DbSet<TblApilogin> TblApilogins { get; set; }
        public virtual DbSet<TblApiuser> TblApiusers { get; set; }       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=95.216.33.247,2019;Initial Catalog=aliansaridb;User ID=ansariuser1;Password=u4@Shr689;Integrated Security=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("ansariuser1");

            modelBuilder.Entity<TblApilogin>(entity =>
            {
                entity.ToTable("tblAPILogin");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Expire)
                    .HasColumnType("datetime")
                    .HasColumnName("expire");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .HasColumnName("token");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<TblApiuser>(entity =>
            {
                entity.ToTable("tblAPIUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .HasColumnName("fullName");

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .HasColumnName("phone");

                entity.Property(e => e.Postal)
                    .HasMaxLength(10)
                    .HasColumnName("postal");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}