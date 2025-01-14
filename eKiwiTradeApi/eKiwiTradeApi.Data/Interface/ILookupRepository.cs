using eKiwiTradeApi.Data.Entity;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupRepository
    {
        Task<List<Category>> GetAllCategoryLookup();

        Task<List<GroupEntity>> GetGroupLookupByCategoryId(int categoryId);

        Task<List<TypeEntity>> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId);

       // Task<string> GetFieldLookup(int id);

    }
}
