using System.Text.RegularExpressions;
using eKiwiTradeApi.Data.Entity;
using eKiwiTradeApi.Logic.Helper;



namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupService
    {
        Task<Response<Category>> GetAllCategoryLookup();
        Task<Response<City>> GetCityLookupByDistrictId(int districtId);
        Task<Response<District>> GetAllDistrictLookup();
        Task<Response<Data.Entity.Group>> GetGroupLookupByCategoryId(int categoryId);
        Task<Response<Suburb>> GetSuburbLookupByCityAndDistrictId(int cityId, int districtId);
        Task<Response<Data.Entity.Type>> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId);


        //Task<Response<string>> GetFieldLookupAsync(int id);
    }

}
