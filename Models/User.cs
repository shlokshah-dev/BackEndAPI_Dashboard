using System;
using System.Collections.Generic;

namespace RevelioLabs.Models
{
    public class User
    {
        public int Id {get; set;}
        
        public string AccountRoles {get; set;}

        public List<AccountPermission> AccountPermissions {get; set;}
    }
}
