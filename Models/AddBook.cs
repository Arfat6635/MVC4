using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    public class AddBook
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookID { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookImage { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        [Required]
        public string BookPrice { get; set; }
        
        public string BookDesc { get; set; }
    }
}