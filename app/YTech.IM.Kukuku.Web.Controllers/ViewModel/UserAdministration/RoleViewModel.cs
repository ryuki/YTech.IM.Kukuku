using System.Collections.Generic;
using System.Web.Security;

namespace YTech.IM.Kukuku.Web.Controllers.ViewModel.UserAdministration
{
    public class RoleViewModel
    {
        public string Role { get; set; }
        public IEnumerable<MembershipUser> Users { get; set; }
    }
}