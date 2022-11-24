using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public partial class User
    {
        public User()
        {
            Diaries = new HashSet<Diary>();
        }

        public int UserId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Username is not empty")]
        public string Username { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password is not empty")]
        public string Password { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "FirstName is not empty")]
        public string FirstName { get; set; } = null!;
        [Required(AllowEmptyStrings = false, ErrorMessage = "LastName is not empty")]
        public string LastName { get; set; } = null!;
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string? Address { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email is not empty"), EmailAddress]
        public string Email { get; set; } = null!;
        [Phone]
        public string? Phone { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<Diary> Diaries { get; set; }
    }
}
