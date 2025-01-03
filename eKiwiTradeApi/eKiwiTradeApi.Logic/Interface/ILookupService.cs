using eKiwiTradeApi.Logic.Helper;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupService
    {
        Task<Response<string>> GetAllLookupAsync();

        Task<Response<string>> GetFieldLookupAsync(int id);
    }
}
