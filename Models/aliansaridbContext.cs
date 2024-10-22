using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace reactAPI.Models
{
    public partial class aliansaridbContext : DbContext
    {
        public aliansaridbContext()
        {
        }

        public aliansaridbContext(DbContextOptions<aliansaridbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblApilogin> TblApilogins { get; set; }
        public virtual DbSet<TblApiuser> TblApiusers { get; set; }
        public virtual DbSet<TblComment> TblComments { get; set; }
        public virtual DbSet<TblContactU> TblContactUs { get; set; }
        public virtual DbSet<TblImage> TblImages { get; set; }
        public virtual DbSet<TblMenu> TblMenus { get; set; }
        public virtual DbSet<TblPost> TblPosts { get; set; }
        public virtual DbSet<TblPostLevel> TblPostLevels { get; set; }
        public virtual DbSet<TblPostType> TblPostTypes { get; set; }
        public virtual DbSet<TblPrice> TblPrices { get; set; }
        public virtual DbSet<TblProject> TblProjects { get; set; }
        public virtual DbSet<TblProjectStack> TblProjectStacks { get; set; }
        public virtual DbSet<TblProjectType> TblProjectTypes { get; set; }
        public virtual DbSet<TblRedirect> TblRedirects { get; set; }
        public virtual DbSet<TblSocial> TblSocials { get; set; }
        public virtual DbSet<TblText> TblTexts { get; set; }
        public virtual DbSet<TblUser> TblUsers { get; set; }
        public virtual DbSet<TblVideo> TblVideos { get; set; }
        public virtual DbSet<ViewProject> ViewProjects { get; set; }
        public virtual DbSet<ViewProjectType> ViewProjectTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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

            modelBuilder.Entity<TblComment>(entity =>
            {
                entity.ToTable("tblComment", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentId).HasColumnName("contentID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAdded");

                entity.Property(e => e.IsAdminReply).HasColumnName("isAdminReply");

                entity.Property(e => e.LikeCount).HasColumnName("likeCount");

                entity.Property(e => e.NameAndFamily)
                    .HasMaxLength(50)
                    .HasColumnName("nameAndFamily");

                entity.Property(e => e.ReplyId).HasColumnName("replyID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Txt)
                    .HasMaxLength(500)
                    .HasColumnName("txt");
            });

            modelBuilder.Entity<TblContactU>(entity =>
            {
                entity.ToTable("tblContactUs", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAdded");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.NameAndFamily)
                    .HasMaxLength(50)
                    .HasColumnName("nameAndFamily");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.Seen).HasColumnName("seen");

                entity.Property(e => e.Txt)
                    .HasMaxLength(2000)
                    .HasColumnName("txt");
            });

            modelBuilder.Entity<TblImage>(entity =>
            {
                entity.ToTable("tblImages", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("address");

                entity.Property(e => e.Alt)
                    .HasMaxLength(500)
                    .HasColumnName("alt");
            });

            modelBuilder.Entity<TblMenu>(entity =>
            {
                entity.ToTable("tblMenu", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(50)
                    .HasColumnName("lnk");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblPost>(entity =>
            {
                entity.ToTable("tblPost", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Canonical)
                    .HasMaxLength(50)
                    .HasColumnName("canonical");

                entity.Property(e => e.DateAdded)
                    .HasColumnType("datetime")
                    .HasColumnName("dateAdded");

                entity.Property(e => e.DescriptionH)
                    .HasMaxLength(50)
                    .HasColumnName("descriptionH");

                entity.Property(e => e.Disc).HasColumnName("disc");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MainImg)
                    .HasMaxLength(50)
                    .HasColumnName("mainImg");

                entity.Property(e => e.PostDisc).HasColumnName("postDisc");

                entity.Property(e => e.PreDisc).HasColumnName("preDisc");

                entity.Property(e => e.ShortDisc)
                    .HasMaxLength(500)
                    .HasColumnName("shortDisc");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.VideoUrl)
                    .HasMaxLength(50)
                    .HasColumnName("videoUrl");

                entity.Property(e => e.VideoUrl1)
                    .HasMaxLength(50)
                    .HasColumnName("videoUrl1");

                entity.Property(e => e.VideoUrl2)
                    .HasMaxLength(50)
                    .HasColumnName("videoUrl2");

                entity.Property(e => e.VideoUrl3)
                    .HasMaxLength(50)
                    .HasColumnName("videoUrl3");

                entity.Property(e => e.VideoUrl4)
                    .HasMaxLength(50)
                    .HasColumnName("videoUrl4");
            });

            modelBuilder.Entity<TblPostLevel>(entity =>
            {
                entity.ToTable("tblPostLevel", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblPostType>(entity =>
            {
                entity.ToTable("tblPostType", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblPrice>(entity =>
            {
                entity.ToTable("tblPrice", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Disc)
                    .HasMaxLength(500)
                    .HasColumnName("disc");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(50)
                    .HasColumnName("lnk");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ShortDisc)
                    .HasMaxLength(50)
                    .HasColumnName("shortDisc");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblProject>(entity =>
            {
                entity.ToTable("tblProject", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgAddress)
                    .HasMaxLength(50)
                    .HasColumnName("imgAddress");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(50)
                    .HasColumnName("lnk");

                entity.Property(e => e.MinDisc)
                    .HasMaxLength(500)
                    .HasColumnName("minDisc");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TblProjectStack>(entity =>
            {
                entity.ToTable("tblProjectStack", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectId).HasColumnName("projectID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblProjectType>(entity =>
            {
                entity.ToTable("tblProjectType", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(50)
                    .HasColumnName("lnk");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblRedirect>(entity =>
            {
                entity.ToTable("TblRedirect", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dest).HasMaxLength(50);

                entity.Property(e => e.Src).HasMaxLength(50);
            });

            modelBuilder.Entity<TblSocial>(entity =>
            {
                entity.ToTable("tblSocial", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(500)
                    .HasColumnName("lnk");

                entity.Property(e => e.Logo)
                    .HasMaxLength(50)
                    .HasColumnName("logo");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TblText>(entity =>
            {
                entity.ToTable("tblText", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Txt).HasColumnName("txt");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("tblUser", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Pass)
                    .HasMaxLength(50)
                    .HasColumnName("pass");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .HasColumnName("userName");
            });

            modelBuilder.Entity<TblVideo>(entity =>
            {
                entity.ToTable("tblVideo", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasMaxLength(500)
                    .HasColumnName("address");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<ViewProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewProjects", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImgAddress)
                    .HasMaxLength(50)
                    .HasColumnName("imgAddress");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(50)
                    .HasColumnName("lnk");

                entity.Property(e => e.MinDisc)
                    .HasMaxLength(500)
                    .HasColumnName("minDisc");

                entity.Property(e => e.ProjectTypeTitle)
                    .HasMaxLength(50)
                    .HasColumnName("projectTypeTitle");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ViewProjectType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("viewProjectType", "dbo");

                entity.Property(e => e.Lnk)
                    .HasMaxLength(50)
                    .HasColumnName("lnk");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
