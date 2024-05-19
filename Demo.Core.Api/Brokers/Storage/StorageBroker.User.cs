using Demo.Core.Api.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace Demo.Core.Api.Brokers.Storage
{
    public partial class StorageBroker
    {
        DbSet<User> Users { get; set; }
        

    }
}
