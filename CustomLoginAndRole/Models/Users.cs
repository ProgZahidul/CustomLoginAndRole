﻿using Microsoft.AspNetCore.Identity;

namespace CustomLoginAndRole.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
