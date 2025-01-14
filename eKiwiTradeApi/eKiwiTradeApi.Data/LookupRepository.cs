using eKiwiTradeApi.Data.DataHelper;
using eKiwiTradeApi.Data.Entity;
using eKiwiTradeApi.Logic.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace eKiwiTradeApi.Data
{
    public class LookupRepository(ApplicationDbContext context, ILogger<LookupRepository> logger) : ILookupRepository
    {
        private readonly ApplicationDbContext _context = context;
        private readonly ILogger<LookupRepository> _logger = logger;

        public async Task<List<Category>> GetAllCategoryLookup()
        {
            try
            {
                return await _context.Categories.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error in GetAllCategoryLookup: {Message}", ex.Message);
                return new List<Category>();
            }
        }



        //public async Task<string> GetFieldLookup(int id)
        //{
        //    try
        //    {
        //        var result = await _collection.Find(c => c["_id"] == id).FirstOrDefaultAsync();
        //        return result.ToJson();
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError("Data-LookupRepository-GetFieldLookup : {0}", ex.Message);
        //        return null;
        //    }
        //}
    }
}
