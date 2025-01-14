using eKiwiTradeApi.Data.Entity;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupRepository
    {
        Task<List<Category>> GetAllCategoryLookup();

        Task<List<Group>> GetGroupLookupByCategoryId(int categoryId);

        Task<List<Data.Entity.Type>> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId);

       // Task<string> GetFieldLookup(int id);

    }
}
