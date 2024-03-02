using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_LGordon.Models
{
    public class MovieAdd
    {
        [Key]
        [Required]
        public int MovieId { get; set; } // Primary Key and getter and setter
                                         // (take out the set if you don't want them to be able to set it)
                                         // Also will make it read-only
        [ForeignKey("CategoryID")] // Setting up Foreign Key relationship to the Categories.cs model/class
        public int? CategoryId { get; set; }
        public Categories? Category { get; set; }
        public string Title { get; set; }
        [Range(1888, 3000, ErrorMessage = "Year must be between 1888 and 3000.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
