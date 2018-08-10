using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ScrimFinder.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ScrimFinderUser class
    public class ScrimFinderUser : IdentityUser
    {
        [Required]
        public string BattleTag { get; set; }
    }
}
