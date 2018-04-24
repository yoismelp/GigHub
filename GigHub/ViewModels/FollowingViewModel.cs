using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModels
{
    public class FollowingViewModel
    {
        public IEnumerable<ApplicationUser> Followees { get; set; }
        public bool ShowActions { get; set; }
    }
}