using DotNetProject.Models;
using DotNetProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DotNetProject.Services
{
    public class UserService : IUser
    {
        private readonly ApplicationDbContext db;

        public UserService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<User> CreateUser(User user)
        {
            db.Users.Add(user);
            await db.SaveChangesAsync();
            return user;
        }

        public async Task<User?> GetUserById(string id)
        {
            var user = await db.Users.FindAsync(id);
            return user;
        }
    }
}
