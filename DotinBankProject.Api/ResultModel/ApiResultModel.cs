namespace DotinBankProject.Api.ResultModel
{
    public class ApiResultModel
    {
        public bool IsSuccess { get; set; } = false; 
        public int Code { get; set; } = 0;
        public string Message { get; set; } = "the action is feild"; 
        public object Data { get; set; }
        public object Errors { get; set; }
    }
}
