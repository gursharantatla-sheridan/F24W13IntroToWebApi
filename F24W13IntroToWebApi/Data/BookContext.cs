using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using F24W13IntroToWebApi.Models;

namespace F24W13IntroToWebApi.Data
{
    public class BookContext : DbContext
    {
        public BookContext (DbContextOptions<BookContext> options)
            : base(options)
        {
        }

        public DbSet<F24W13IntroToWebApi.Models.Book> Book { get; set; } = default!;
    }
}
