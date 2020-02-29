using System.Net;

namespace ExampleAPI.Models
{
    public class DefaultError
    {
        public HttpStatusCode code { get; set; }
        public string message { get; set; }

        public DefaultError(HttpStatusCode _code, string _message)
        {
            code = _code;
            message = _message;
        }
    }
}