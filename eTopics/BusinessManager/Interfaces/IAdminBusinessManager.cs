using eTopics.Models.AdminViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace eTopics.BusinessManager.Interfaces
{
    public interface IAdminBusinessManager
    {
        public Task<IndexViewModel> GetAdminDashBoard(ClaimsPrincipal claimsPrincipal);
    }
}
