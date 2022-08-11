using Habbitz.PoultryGuide.Application.DTOs.Feeds;
using System.Net.Http;
using System.Threading.Tasks;

namespace Habbitz.PoultryGuide.MVC.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get;}

        Task FeedsPOSTAsync(CreateFeedDto feedDto);
    }
}
