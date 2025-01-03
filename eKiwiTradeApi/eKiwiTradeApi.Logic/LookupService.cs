using AutoMapper;
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
        public async Task<Response<string>> GetAllLookupAsync()
        {
            var response = new Response<string>();
            try
            {
                var lookupResult = await _lookupRepository.GetCategoryLookup();
                if (!string.IsNullOrEmpty(lookupResult))
                {
                    response.Success = true;
                    response.Data = lookupResult;
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

        public async Task<Response<string>> GetFieldLookupAsync(int fieldId)
        {
            var response = new Response<string>();
            try
            {
                var lookupResult = await _lookupRepository.GetFieldLookup(fieldId);
                if (!string.IsNullOrEmpty(lookupResult))
                {
                    response.Success = true;
                    response.Data = lookupResult;
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
