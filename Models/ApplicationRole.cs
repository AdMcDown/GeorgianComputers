using Microsoft.AspNetCore.Identity; // connection to IdentityRole
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeorgianComputers.Models
{
    //used to manage ROLES for authorization and inherits from IdentityRole
    public class ApplicationRole : IdentityRole
    {
    }
}
