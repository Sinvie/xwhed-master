namespace Sinvie.M.D.U.Api.Controllers
{
    internal class ApiResultModel
    {
        public ApiResultModel()
        {
        }

        public string status { get; set; }
        public string log { get; set; }
        public string data { get; set; }
    }
}