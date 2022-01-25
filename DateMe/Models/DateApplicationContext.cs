using System;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{

    public class DateApplicationContext: DbContext
    {
        //constructor
       public DateApplicationContext(DbContextOptions<DateApplicationContext> options) : base (options)
        {
            //leave blank for now
        }
        public DbSet<DateApplicationContext> responses { get; set; }
    }
}
