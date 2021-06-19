using eTopics.Data;
using eTopics.Data.Models;
using eTopics.Service.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace eTopics.Service {
    public class UserService : IUserService {
        private readonly ApplicationDbContext applicationDbContext;

        public UserService(ApplicationDbContext applicationDbContext) {
            this.applicationDbContext = applicationDbContext;
        }

        public ApplicationUsers Get(string id) {
            return applicationDbContext.Users
                .FirstOrDefault(user => user.Id == id);
        }

        public async Task<ApplicationUsers> Update(ApplicationUsers applicationUser) {
            applicationDbContext.Update(applicationUser);
            await applicationDbContext.SaveChangesAsync();
            return applicationUser;
        }
    }
}