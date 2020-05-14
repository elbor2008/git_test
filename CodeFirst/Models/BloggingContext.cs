using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

        //public DbSet<BlogPost> BlogPosts { get; set; }

        //public DbSet<Author> Authors { get; set; }
        //public DbSet<Order> Orders { get; set; }

        //public DbSet<RssBlog> RssBlogs { get; set; }


        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<BlogPost>().HasKey(bp => new { bp.BlogId, bp.PostId });

            //modelBuilder.Entity<BlogPost>().HasOne(bp => bp.Blog).WithMany().HasForeignKey(bp => bp.BlogId);
            //modelBuilder.Entity<BlogPost>().HasOne(bp => bp.Post).WithMany().HasForeignKey(bp => bp.PostId);

            //modelBuilder.Entity<Author>().HasOne(a => a.Blog).WithMany().OnDelete(DeleteBehavior.SetNull);
            //modelBuilder.Entity<RssBlog>().HasBaseType((Type)null);
            //modelBuilder.Entity<Order>().OwnsOne(o => o.orderAddress, builder =>
            //{

            //});
            modelBuilder.Entity<Blog>().Property(b => b.Name).HasMaxLength(20);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
    }
}
