using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;


namespace MvcMovie.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> option) : base(option)
        {}
        public DbSet<Person> Person {get; set;}
    }
}