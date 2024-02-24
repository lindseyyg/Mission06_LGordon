using System.ComponentModel.DataAnnotations;

namespace Mission06_LGordon.Models
{
    public class MovieAdd
    {
        [Key]
        [Required]
        public int MovieID { get; set; } // Primary Key and getter and setter
                                         // (take out the set if you don't want them to be able to set it)
                                         // Also will make it read-only
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        public string? Notes { get; set; }

    }
}
