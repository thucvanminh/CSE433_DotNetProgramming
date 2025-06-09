﻿using Microsoft.EntityFrameworkCore;

namespace MinhThuc_Lab3.Models
{

    public class Lab3DotnetContext : DbContext
    {
        public Lab3DotnetContext(DbContextOptions<Lab3DotnetContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Carousel> Carousels { get; set; }
    }

}
