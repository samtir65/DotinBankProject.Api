using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotinBankProject.Api.ResultModel
{
    public class ApiResultModel
    {
        public bool IsSuccess { get; set; } = false; 
        public int Code { get; set; } = 0;
        public string Message { get; set; } = "عملیات با خطا مواجه گردید"; 
        public object Data { get; set; }
        public object Errors { get; set; }
    }
}
