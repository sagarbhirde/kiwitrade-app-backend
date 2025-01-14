using AutoMapper;
using eKiwiTradeApi.Data;
using eKiwiTradeApi.Logic.Helper;
using eKiwiTradeApi.Logic.Interface;
using eKiwiTradeApi.Logic.Model;
using Microsoft.Extensions.Logging;

namespace eKiwiTradeApi.Logic
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<UserService> _logger;

        public UserService(IUserRepository userRepository, IMapper mapper, ILogger<UserService> logger)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<Response<List<UserModel>>> GetAllUserAsync()
        {
            var response = new Response<List<UserModel>>();
            try
            {
                //var users = await _userRepository.GetAllUserAsync();
                //if (users != null)
                //{
                //    response.Success = true;
                //    response.Data = _mapper.Map<List<UserModel>>(users);
                //}
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-UserService-GetAllUserAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<UserModel>> GetUserByIdAsync(string id)
        {
            var response = new Response<UserModel>();
            try
            {
                //var result = await _userRepository.GetUserByIdAsync(id);
                //if(result != null)
                //{
                //    response.Success = true;
                //    response.Data = _mapper.Map<UserModel>(result);
                //}
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-UserService-GetUserByIdAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<UserModel>> CreateUserAsync(UserModel userModel)
        {
            var response = new Response<UserModel>();
            try
            {

                //var user = _mapper.Map<User>(userModel);
                //if (await _userRepository.CreateUserAsync(user))
                //{
                //    response.Success = true;
                //}
                //else
                //{
                //    response.Success = false;
                //    response.ErrorMessage = string.Empty;
                //}

            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-UserService-CreateUserAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<UserModel>> UpdateUserAsync(string id, UserModel userModel)
        {

            var response = new Response<UserModel>();
            try
            {

                //var user = _mapper.Map<User>(userModel);
                //if (await _userRepository.UpdateUserAsync(id, user))
                //{
                //    response.Success = true;
                //}
                //else
                //{
                //    response.Success = false;
                //    response.ErrorMessage = string.Empty;
                //}

            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-UserService-UpdateUserAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;

        }

    }
}
