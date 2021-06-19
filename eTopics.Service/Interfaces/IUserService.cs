using eTopics.Data.Models;
using System.Threading.Tasks;

namespace eTopics.Service.Interfaces {
    public interface IUserService {
        ApplicationUsers Get(string id);
        Task<ApplicationUsers> Update(ApplicationUsers applicationUser);
    }
}