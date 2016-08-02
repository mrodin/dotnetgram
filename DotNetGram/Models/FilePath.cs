using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNetGram.Models
{
    public class FilePath
    {
        [Key]
        [ForeignKey("Post")]
        public int? PostID { get; set; }

        [StringLength(255)]
        public string FileName { get; set; }
        public FileType FileType { get; set; }

        public virtual Post Post { get; set; }
    }
}