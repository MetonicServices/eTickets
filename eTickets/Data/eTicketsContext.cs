using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eTickets.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace eTickets.Data
{
    public class eTicketsContext : IdentityDbContext<IdentityUser>
    {
        public eTicketsContext(DbContextOptions<eTicketsContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor)
                .WithMany(am => am.Actors_Movies)
                .HasForeignKey(m => m.ActorId);
        }

        public DbSet<Actor> Actors { get; set; } = default!;
        public DbSet<Movie> Movies { get; set; } = default!;
        public DbSet<Actor_Movie> Actors_Movies { get; set; } = default!;
        public DbSet<Cinema> Cinemas { get; set; } = default!;
        public DbSet<Producer> Producers { get; set; } = default!;

        //Orders related tables
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderItem> OrderItems { get; set; } = default!;
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;
    }
}
