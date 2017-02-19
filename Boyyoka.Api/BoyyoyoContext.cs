namespace Boyyoka.Api
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BoyyoyoContext : DbContext
    {
        public BoyyoyoContext()
            : base("name=BoyyoyoContext")
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Wallpaper> Wallpapers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Avatar)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.StickyWall)
                .IsUnicode(false);

            modelBuilder.Entity<Wallpaper>()
                .Property(e => e.Resolution)
                .IsUnicode(false);

            modelBuilder.Entity<Wallpaper>()
                .Property(e => e.Purity)
                .IsUnicode(false);

            modelBuilder.Entity<Wallpaper>()
                .Property(e => e.Type)
                .IsUnicode(false);

            modelBuilder.Entity<Wallpaper>()
                .Property(e => e.Path)
                .IsUnicode(false);

            modelBuilder.Entity<Wallpaper>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<Wallpaper>()
                .Property(e => e.Thumbnail)
                .IsUnicode(false);
        }
    }
}
