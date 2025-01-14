using System.Text.RegularExpressions;
using eKiwiTradeApi.Data.Entity;
using eKiwiTradeApi.Logic.Helper;



namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupService
    {
        Task<Response<Category>> GetAllCategoryLookup();
        Task<Response<GroupEntity>> GetGroupLookupByCategoryId(int categoryId);
        Task<Response<TypeEntity>> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId);
        //Task<Response<string>> GetFieldLookupAsync(int id);
    }

}
