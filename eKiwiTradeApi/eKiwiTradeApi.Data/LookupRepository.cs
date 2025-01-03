using eKiwiTradeApi.Data.DataHelper;
using eKiwiTradeApi.Logic.Interface;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace eKiwiTradeApi.Data
{
    public class LookupRepository : ILookupRepository
    {
        private readonly IMongoCollection<BsonDocument> _collection; // class-level field
        private readonly DbConfiguration _settings;
        private readonly ILogger<LookupRepository> _logger;

        public LookupRepository(IOptions<DbConfiguration> settings, ILogger<LookupRepository> logger)
        {
            _settings = settings.Value;
            var client = new MongoClient(_settings.ConnectionString);
            var database = client.GetDatabase(_settings.DatabaseName);

            // Assign the class-level field
            _collection = database.GetCollection<BsonDocument>(DataConstants.LookupCollectionName);

            _logger = logger;
        }

        public async Task<string> GetCategoryLookup()
        {
            try
            {
                var result = await _collection.Find(c => c["_id"] == DataConstants.CategoryLookupId).FirstOrDefaultAsync();
                return result.ToJson();
            }
            catch (Exception ex)
            {
                _logger.LogError("Data-LookupRepository-GetCategoryLookup : {0}", ex.Message);
                return null;
            }
        }

        public async Task<string> GetFieldLookup(int id)
        {
            try
            {
                var result = await _collection.Find(c => c["_id"] == id).FirstOrDefaultAsync();
                return result.ToJson();
            }
            catch (Exception ex)
            {
                _logger.LogError("Data-LookupRepository-GetFieldLookup : {0}", ex.Message);
                return null;
            }
        }
    }
}
