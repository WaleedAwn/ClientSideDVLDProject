using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainDVLD.Globals
{
    public enum ApiResponseStatus
    {
        Success,
        BadRequest,
        NotFound,
        ServerError,
        Unauthorized,
        Conflict
    }
}
