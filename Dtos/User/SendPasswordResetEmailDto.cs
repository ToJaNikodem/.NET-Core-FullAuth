using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FullAuth.Dtos.User
{
    public class SendPasswordResetEmailDto
    {
        [Required]
        public string? Email { get; set; }
    }
}