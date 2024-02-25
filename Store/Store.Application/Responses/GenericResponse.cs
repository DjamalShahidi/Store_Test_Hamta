using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Responses
{
    public class GenericResponse<T>
    {
        public bool Success { get; set; }

        public T Data { get; set; }
    }
}
