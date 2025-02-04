using System;
using GameStore.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.API.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options) 
 : DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Fighting"},
            new { Id = 2, Name = "Racing"},
            new { Id = 3, Name = "Sports"},
            new { Id = 4, Name = "RPG"},
            new { Id = 5, Name = "Open world"},
            new { Id = 6, Name = "Simulator"},
            new { Id = 7, Name = "VR"}
        );
        
    }
}
