using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpResponse.Enum;
using HttpResponse.Models;

namespace HttpResponse
{
    public class ResponseResult
    {
        public static Result Failed()
        {
            return new Result(new ResultCode(ResultEnum.Failed));
        }
    }

    public class ResponseResult<T>
    {
        public static Result<T> Success(T data)
        {
            return new Result<T>(new ResultCode(ResultEnum.Success), data);
        }
    }
}
