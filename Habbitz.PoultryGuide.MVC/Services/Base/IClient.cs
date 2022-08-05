using System.Net.Http;

namespace Habbitz.PoultryGuide.MVC.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get;}
    }
}
