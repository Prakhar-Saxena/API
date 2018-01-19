using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Services
{
    public class Reader
    {
        public Model1 GetStuff(DateTime dateTime)
        {
            var result = new Model1();
            try
            {
                //after adding the ado.net database
                //var rebalancerEntities = new RebalancerEntities();

                //using the linq in Entity framework
                var tempInfo = (from app in rebalancerEntities.BatchJobStatus where app.UniverseDate == dateTime select app).ToList();

                var info = new Model1
                {
                    attribute1 = tempInfo[0].attribute1,
                    attribute2 = tempInfo[0].attribute2,
                    attribute3 = tempInfo[0].attribute3,
                };
                result = info;
            }
            catch (Exception e)
            {
                Console.WriteLine("GetStuff() Error");
                Console.WriteLine(e.Message);
            }
            return result;
        }
    }
}