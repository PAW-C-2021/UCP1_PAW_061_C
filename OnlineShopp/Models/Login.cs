using System;
using System.Collections.Generic;

#nullable disable

namespace OnlineShopp.Models
{
    public partial class Login
    {
        public int IdLogin { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Info { get; set; }
    }
}
