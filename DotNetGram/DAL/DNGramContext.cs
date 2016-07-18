using DotNetGram.Models;
using System.Data.Entity;

namespace DotNetGram.DAL
{
    public class DNGramContext : DbContext
    {
        public DNGramContext() : base("DNGramContext")
        {
        }

        public DbSet<Post> Posts { get; set; }
    }
}