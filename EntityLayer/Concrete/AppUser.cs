using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string ImageURL { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; } = Gender.NotSpecified;

    }
    public enum Gender
    {
        NotSpecified,
        Male,
        Female
        
    }
}
