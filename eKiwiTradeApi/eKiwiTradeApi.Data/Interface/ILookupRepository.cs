namespace eKiwiTradeApi.Logic.Interface
{
    public interface ILookupRepository
    {
        Task<string> GetCategoryLookup();

        Task<string> GetFieldLookup(int id);

    }
}
