using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeBlogWebapp.Models;

namespace RecipeBlogWebapp.Data
{
    public class RecipeBlogWebappContext : DbContext
    {
        public RecipeBlogWebappContext (DbContextOptions<RecipeBlogWebappContext> options)
            : base(options)
        {
        }

        public DbSet<RecipeBlogWebapp.Models.Recipe> Recipe { get; set; } = default!;

        public DbSet<RecipeBlogWebapp.Models.User> User { get; set; } = default!;
    }
}
