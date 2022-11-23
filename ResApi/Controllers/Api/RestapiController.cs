using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ResApi.Controllers.Api
{
    [Route("api/Restapi")]
    [ApiController]
    public class RestapiController : ControllerBase
    {
        public class patient
        {
            //public string firstname { get; set; }
            //public string email { get; set; }
            //public string lastname { get; set; }
            public IFormFile? file { get; set; }
        }
        [HttpGet]
        [Route("SaveDate")]
        public string SaveData(IFormFile file)
        {

            return "";
        }
    }
}
