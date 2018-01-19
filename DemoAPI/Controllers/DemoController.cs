using DemoAPI.Models;
using DemoAPI.Services;
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

        [Route("api/BJS/{dateString}")]
        [HttpGet]
        public Model1 GetModel1(string dateString)
        {
            DateTime dateTime = new DateTime();

            var reader = new Reader();
            try
            {
                dateString = dateString.Trim();
                if (!DateTime.TryParse(dateString, out dateTime))
                {
                    throw new Exception();
                }
                else if (DateTime.TryParse(dateString, out dateTime))
                {
                    return reader.GetStuff(dateTime);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error! Wrong date entered!");
                Console.WriteLine(e.Message);
                return null;
            }

        }
    }
}
