using eKiwiTradeApi.Data.Entity;
using eKiwiTradeApi.Logic.Helper;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupService
    {
        Task<Response<Category>> GetAllCategoryLookup();

        //Task<Response<string>> GetFieldLookupAsync(int id);
    }
}
