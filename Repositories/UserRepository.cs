using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RevelioLabs.Models;

namespace RevelioLabs.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext context;

        public UserRepository(UserContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<User> GetUser(int userId)
        {
            return await context.Users.FindAsync(userId);
        }

        public async Task<User> CreateUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteUser(int userId)
        {
            User userToDelete = await context.Users.FindAsync(userId);
            context.Users.Remove(userToDelete);

            await context.SaveChangesAsync();
        }
    }
}