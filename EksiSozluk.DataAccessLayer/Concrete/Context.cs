using EksiSozluk.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EksiSozluk.DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<User, Role, int> //DbContext //IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-13123BI;initial catalog=EksiSozlukDb;integrated security=true");
        }
        public DbSet<FavoriteComment> FavoriteComments { get; set; }
        public DbSet<FavoriteTopic> FavoriteTopics { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentImage> CommentImages { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactCategory> ContactCategories { get; set; }
        public DbSet<Expression> Expressions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
