using eKiwiTradeApi.Data.Entity;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupRepository
    {
        Task<List<Category>> GetAllCategoryLookup();
        Task<List<District>> GetAllDistrictLookup();
        Task<List<Group>> GetGroupLookupByCategoryId(int categoryId);

    
        Task<List<City>> GetCityLookupByDistrictId(int districtId);

        Task<List<Suburb>> GetSuburbLookupByCityAndDistrictId(int cityId, int districtId);

        Task<List<Data.Entity.Type>> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId);

       // Task<string> GetFieldLookup(int id);

    }
}
