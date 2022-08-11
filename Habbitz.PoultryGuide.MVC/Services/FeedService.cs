using AutoMapper;
using Habbitz.PoultryGuide.MVC.Contracts;
using Habbitz.PoultryGuide.MVC.Models;
using Habbitz.PoultryGuide.MVC.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.MVC.Services
{
    public class FeedService : BaseHttpService, IFeedService
    {
        private readonly IMapper _mapper;
        private readonly IClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public FeedService(IMapper mapper, IClient httpClient, ILocalStorageService localStorageService) : base(httpClient,localStorageService)
        {
            _mapper = mapper;
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        public Task<Response<int>> CreateFeed(CreateFeedVM feed)
        {
            throw new NotImplementedException();
        }

        //public async Task<Response<int>> CreateFeed(CreateFeedVM feed)
        //{
        //    try
        //    {
        //        var response = new Response<int>();
        //        FeedDto feedDto = _mapper.Map<FeedDto>(feed);
        //        var apiResponse = await _client.FeedsPOSTAsync(feedDto);
        //        if (apiResponse.Success)
        //        {
        //            response.Data = apiResponse.Id;
        //            response.Success = true;
        //        }
        //        else
        //        {
        //            foreach (var error in apiResponse.Errors)
        //            {
        //                response.ValidationErrors += error + Environment.NewLine;
        //            }
        //        }

        //        return response;
        //    }
        //    catch(ApiException ex)
        //    {
        //        return ConvertApiExceptions<int>(ex);
        //    }
        //}

        public async Task<Response<int>> DeleteFeed(int id)
        {
            try
            {
                await _client.FeedsDELETEAsync(id);
                return new Response<int>() { Success = true };
            }catch(ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            } 
        }

        public async Task<FeedVM> GetFeedDetails(int id)
        {
            var feed = await _client.FeedsGETAsync(id);
            return _mapper.Map<FeedVM>(feed);
        }

        public async Task<List<FeedVM>> GetFeeds()
        {
            var feeds = await _client.FeedsAllAsync();
            return _mapper.Map<List<FeedVM>>(feeds);
        }

        public async Task<Response<int>> UpdateFeed(int id, FeedVM feed)
        {
            try
            {
                UpdateFeedDto feedDto = _mapper.Map<UpdateFeedDto>(feed);
                await _client.FeedsPUTAsync(id, feedDto);
                return new Response<int>() { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptions<int>(ex);
            }
        }
    }
}
