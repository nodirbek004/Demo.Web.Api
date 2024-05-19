using Demo.Core.Api.Models.Users;

namespace Demo.Core.Api.Brokers.Storage
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InserUserAsync(User user);
        IQueryable<User> SelectAllUsers();
        ValueTask<User> SelectUserByIdAsync(int id);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}
