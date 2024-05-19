using Demo.Core.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Demo.Core.Api.Brokers.Storage
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }

        public async ValueTask<User> InserUserAsync(User user) =>
            await InsertAsync(user);

        public IQueryable<User> SelectAllUsers() =>
            SelectAll<User>();

        public async ValueTask<User> SelectUserByIdAsync(int id) =>
            await SelectAsync<User>(id);

        public async ValueTask<User> UpdateUserAsync(User user) =>
            await UpdateAsync(user);

        public async ValueTask<User> DeleteUserAsync(User user) =>
            await DeleteAsync(user);
    }
}
