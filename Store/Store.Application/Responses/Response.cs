using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Responses
{
    public class Response
    {
        public Response()
        {
            StatusCode = HttpStatusCode.OK;
            ErrorMessages = [];
            Result = null;
            IsSuccess = true;
        }
        public Response(object result)
        {
            StatusCode = HttpStatusCode.Created;
            IsSuccess = true;
            ErrorMessages = [];
            Result = result;
        }
        public Response(HttpStatusCode status, List<string> errors)
        {
            StatusCode = status;
            IsSuccess = false;
            ErrorMessages = errors;
            Result = null;
        }
        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
