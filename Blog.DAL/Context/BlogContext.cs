using BlogDomain.Core;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Context
{
    public class BlogContext : IdentityDbContext<AdminUser>
    {
        public BlogContext() : base("BlogConnection")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<SiteMenu> SiteMenus { get; set; }
        public DbSet<BlogPostComment> BlogPostComments { get; set; }

        public static BlogContext Create()
        {
            return new BlogContext();
        }

    }
}
