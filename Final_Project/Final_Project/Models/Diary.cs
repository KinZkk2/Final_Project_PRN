using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public partial class Diary
    {
        public int DiaryId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Title is not empty")]
        public string Title { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Contents is not empty")]
        public string Contents { get; set; } = null!;
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public bool Favorite { get; set; }

        public virtual User User { get; set; } = null!;

        
    }
}
