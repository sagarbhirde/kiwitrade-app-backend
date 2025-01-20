using AutoMapper;
using eKiwiTradeApi.Data.Entity;
using eKiwiTradeApi.Logic.Helper;
using eKiwiTradeApi.Logic.Interface;
using Microsoft.Extensions.Logging;

namespace eKiwiTradeApi.Logic
{
    public class LookupService : ILookupService
    {
        private readonly ILookupRepository _lookupRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<LookupService> _logger;

        public LookupService(ILookupRepository lookupRepository, IMapper mapper, ILogger<LookupService> logger)
        {
            _lookupRepository = lookupRepository;
            _mapper = mapper;
            _logger = logger;
        }


        //TODO: Implement Cahse 
        public async Task<Response<Category>> GetAllCategoryLookup()
        {
            var response = new Response<Category>();
            try
            {
                var lookupResult = await _lookupRepository.GetAllCategoryLookup();
                if (lookupResult != null)
                {
                    response.Success = true;
                    response.Datas = lookupResult;
                }
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-LookupService-GetAllLookupAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<Group>> GetGroupLookupByCategoryId(int categoryId)
        {
            var response = new Response<Group>();
            try
            {
                var lookupResult = await _lookupRepository.GetGroupLookupByCategoryId(categoryId);
                if (lookupResult != null)
                {
                    response.Success = true;
                    response.Datas = lookupResult;
                }
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-LookupService-GetAllLookupAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<Data.Entity.Type>> GetTypeLookupByGroupAndCategoryId(int groupId, int categoryId)
        {
            var response = new Response<Data.Entity.Type>();
            try
            {
                var lookupResult = await _lookupRepository.GetTypeLookupByGroupAndCategoryId(groupId, categoryId);
                if (lookupResult != null)
                {
                    response.Success = true;
                    response.Datas = lookupResult;
                }
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-LookupService-GetAllLookupAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<District>> GetAllDistrictLookup()
        {
            var response = new Response<District>();
            try
            {
                var lookupResult = await _lookupRepository.GetAllDistrictLookup();
                if (lookupResult != null)
                {
                    response.Success = true;
                    response.Datas = lookupResult;
                }
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-LookupService-GetAllLookupAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<City>> GetCityLookupByDistrictId(int districtId)
        {
            var response = new Response<City>();
            try
            {
                var lookupResult = await _lookupRepository.GetCityLookupByDistrictId(districtId);
                if (lookupResult != null)
                {
                    response.Success = true;
                    response.Datas = lookupResult;
                }
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-LookupService-GetAllLookupAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

        public async Task<Response<Suburb>> GetSuburbLookupByCityAndDistrictId(int cityId, int districtId)
        {
            var response = new Response<Suburb>();
            try
            {
                var lookupResult = await _lookupRepository.GetSuburbLookupByCityAndDistrictId(cityId, districtId);
                if (lookupResult != null)
                {
                    response.Success = true;
                    response.Datas = lookupResult;
                }
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Logic-LookupService-GetAllLookupAsync {0}", ex.Message);
                response.Success = false;
            }

            return response;
        }

    }
}
