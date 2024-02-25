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
            ErrorMessages = [];
            Result = null;
            IsSuccess = true;
        }
        public Response(object result)
        {
            IsSuccess = true;
            ErrorMessages = [];
            Result = result;
        }
        public Response(List<string> errors)
        {
            IsSuccess = false;
            ErrorMessages = errors;
            Result = null;
        }
        public bool IsSuccess { get; set; } = true;
        public List<string> ErrorMessages { get; set; }
        public object Result { get; set; }
    }
}
