using Microsoft.EntityFrameworkCore;
using FirstWebMvc.Models;


namespace FirstWebMvc
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> option) : base(options)
        {}
        public DbSet<Person> Person {get; set;}
    }
}