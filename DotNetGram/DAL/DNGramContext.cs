using DotNetGram.Models;
using System.Data.Entity;

namespace DotNetGram.DAL
{
    public class DNGramContext : DbContext
    {
        public DNGramContext() : base("DNGramContext")
        {
            Database.SetInitializer<DNGramContext>(new DropCreateDatabaseIfModelChanges<DNGramContext>());
        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<FilePath> FilePaths { get; set; }
    }
}