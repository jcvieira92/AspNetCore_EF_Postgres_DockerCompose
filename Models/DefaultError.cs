using System.Net;

namespace TesteAPI.Models
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