using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Web.Http;

namespace DemoAPI.Controllers
{
    //[EnableCors(origins: "*", headers: "*", methods: "*")]
    public class DemoController : ApiController
    {

        [Route("api/user")]
        [HttpGet]
        public string GetWindowsUser()
        {
            var id = WindowsIdentity.GetCurrent();

            return id.Name;
        }
    }
}
