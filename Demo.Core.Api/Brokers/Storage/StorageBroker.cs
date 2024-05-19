namespace Demo.Core.Api.Brokers.Storage
{
    public partial class StorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
        
        }
    }
}
