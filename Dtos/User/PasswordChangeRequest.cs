using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullAuth.Dtos.User
{
    public class PasswordChangeRequest
    {
        [Required]
        [MaxLength(36)]
        public string UserId { get; set; } = string.Empty;
        [Required]
        [MaxLength(64)]
        public string OldPassword { get; set; } = string.Empty;
        [Required]
        [StringLength(64, MinimumLength = 10, ErrorMessage = "Password must be between 10 and 64 characters long!")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\^#@$!%*?&])[A-Za-z\d\^#@$!%*?&]{10,}$", ErrorMessage = "Password must contain at least one number, one special character (^#@$!%*?&), one uppercase and one lower case letter!")]
        public string NewPassword { get; set; } = string.Empty;
    }
}