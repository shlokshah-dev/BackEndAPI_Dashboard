using System.Collections.Generic;
using System.Threading.Tasks;
using RevelioLabs.Models;

namespace RevelioLabs.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();

        Task<User> GetUser(int userId);

        Task<User> CreateUser(User user);

        Task UpdateUser(User user);

        Task DeleteUser(int userId);
    }
}