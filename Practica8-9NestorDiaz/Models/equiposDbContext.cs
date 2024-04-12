using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace Practica8_9NestorDiaz.Models
{
    public class equiposDbContext : DbContext
    {
        public equiposDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Marcas> marcas { get; set; }
        public DbSet<Equipos> equipos { get; set; }
    }
}
