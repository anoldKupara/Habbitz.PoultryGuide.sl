using Habbitz.PoultryGuide.MVC.Models;
using Habbitz.PoultryGuide.MVC.Services.Base;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.MVC.Contracts
{
    public interface IFeedService
    {
        Task<List<FeedVM>> GetFeeds();
        Task<FeedVM> GetFeedDetails(int id);
        Task<Response<int>> CreateFeed(CreateFeedVM feed);
        Task<Response<int>> UpdateFeed(int id, FeedVM feed);   
        Task<Response<int>> DeleteFeed(int id);
    }
}
