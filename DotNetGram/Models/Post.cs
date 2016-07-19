namespace DotNetGram.Models
{
    public class Post
    {
        public int ID { get; set; }
        public string Caption { get; set; }

        public virtual FilePath FilePath { get; set; }
    }
}