using eKiwiTradeApi.Logic.Model;

namespace eKiwiTradeApi.Logic.Interface
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUserAsync();

        Task<User> GetUserByIdAsync(string id);

        Task<bool> CreateUserAsync(User customer);

        Task<bool> UpdateUserAsync(string id, User customer);

    }
}
