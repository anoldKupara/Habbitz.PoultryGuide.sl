namespace Habbitz.PoultryGuide.MVC.Services.Base
{
    public class Response<T>
    {
        public string Message { get; set; }
        public string ValidationResult { get; set; }
        public bool Success { get; set; }
        public T Data { get; set; }
        public int ValidationErrors { get; internal set; }
    }
}
