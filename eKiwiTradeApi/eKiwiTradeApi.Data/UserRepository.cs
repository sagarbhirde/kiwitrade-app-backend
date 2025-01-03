using eKiwiTradeApi.Data.DataHelper;
using eKiwiTradeApi.Logic.Interface;
using eKiwiTradeApi.Logic.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace eKiwiTradeApi.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _collection;
        private readonly DbConfiguration _settings;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(IOptions<DbConfiguration> settings, ILogger<UserRepository> logger)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);
            _collection = database.GetCollection<User>(DataConstants.UserCollectionName);
            _logger = logger;
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            try
            {
                var result = await _collection.Find(_ => true).ToListAsync();
                return result;
            }
            catch (Exception ex)
            {
                _logger.LogError("Data-UserRepository-CreateUserAsync : {0}", ex.Message);
                return null;
            }
        }
        public async Task<User> GetUserByIdAsync(string id)
        {
            try
            {
                return await _collection.Find(c => c.Id == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError("Data-UserRepository-CreateUserAsync : {0}", ex.Message);
                return null;
            }
        }
        public async Task<bool> CreateUserAsync(User customer)
        {
            try
            {
                customer.Id = ObjectId.GenerateNewId().ToString();
                await _collection.InsertOneAsync(customer).ConfigureAwait(false);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError("Data-UserRepository-CreateUserAsync : {0}", ex.Message);
                return false;
            }
        }
        public async Task<bool> UpdateUserAsync(string id, User customer)
        {
            try
            {
                await _collection.ReplaceOneAsync(c => c.Id == id, customer);
                return true;
            }
            catch (Exception ex)
            {

                _logger.LogError("Data-UserRepository-UpdateUserAsync : {0}", ex.Message);
                return false;
            }

        }
        //public Task DeleteAsync(string id)
        //{
        //    return _collection.DeleteOneAsync(c => c.Id == id);
        //}
    }
}
