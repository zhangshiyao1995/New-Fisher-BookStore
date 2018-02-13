using System;
using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Api.Models;

namespace Fisher.Bookstore.Api.Models

{

    public class BookstoreContext : DbContext

    {
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
           : base(options)
           {

           }
        public DbSet<Book> Books {get; set;}
        
        public DbSet<Author> Authors {get; set;}
    }

    
}