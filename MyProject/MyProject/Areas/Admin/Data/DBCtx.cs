using Microsoft.EntityFrameworkCore;
using MyProject.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Areas.Admin.Data
{
    public class DBCtx: DbContext
    {
        public DBCtx(DbContextOptions<DBCtx> options) : base(options)
        {

        }

      

        public DbSet<News> News { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
