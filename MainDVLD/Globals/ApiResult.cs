using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Globals
{
    public class ApiResult<T>
    {
        public bool IsSuccess { get; set; }
        public T? Result { get; set; } // Holds the actual response data
        public string? ErrorMessage { get; set; } // Holds any error message returned by the API
        public ApiResponseStatus Status { get; set; } // Generalized status code
    }
}
