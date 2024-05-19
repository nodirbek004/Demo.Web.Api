// -------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE FOR THE WORLD
// -------------------------------------------------------


namespace Demo.Core.Api.Brokers.Storage
{
    public partial interface IStorageBroker
    {
        ValueTask<User> InserUserAsync(User user);
        IQueriable<User> SelectAllUser();
        ValueTask<User> SelectUserByIdAsync(int id);
        ValueTask<User> UpdateUserAsync(User user);
        ValueTask<User> DeleteUserAsync(User user);
    }
}
