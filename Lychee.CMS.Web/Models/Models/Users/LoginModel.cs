﻿using Lychee.CMS.Web.Models.Interface.Users;
using System.ComponentModel.DataAnnotations;

namespace Lychee.CMS.Web.Models.Models.Users
{
    public class LoginModel : ILoginModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}