using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpResponse.Enum
{
    public enum ResultEnum
    {
        Success,
        Failed,
        ParamIsInvalid
    }
    public class ResultCode
    {
        public int Code { get; private set; }
        public string Message { get; private set; }

        public ResultCode(ResultEnum result)
        {
            switch (result)
            {
                case ResultEnum.Success:
                    Code = 1;
                    Message = "Success";
                    break;
                case ResultEnum.Failed:
                    Code = -1;
                    Message = "Failed";
                    break;
                case ResultEnum.ParamIsInvalid:
                    Code = 1001;
                    Message = "Invalid Parameters";
                    break;
                default:
                    Code = 0;
                    Message = "Unknown Result";
                    break;
            }
        }
    }
}
