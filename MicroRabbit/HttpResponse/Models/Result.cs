using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HttpResponse.Enum;

namespace HttpResponse.Models
{
    public class Result
    {
        public int Code { get; protected set; }

        public string Message { get; protected set; }

        public string Data { get; protected set; }

        public Result(ResultCode resultCode)
        {
            Code = resultCode.Code;
            Message = resultCode.Message;
            Data = null;
        }
    }

    public class Result<T>
    {
        public int Code { get; protected set; }

        public string Message { get; protected set; }

        public T Data { get; protected set; }

        public Result(ResultCode resultCode)
        {
            Code = resultCode.Code;
            Message = resultCode.Message;
            Data = default(T);
        }

        public Result(ResultCode resultCode, T data)
        {
            Code = resultCode.Code;
            Message = resultCode.Message;
            Data = data;
        }
    }
}
