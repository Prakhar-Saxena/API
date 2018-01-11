using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    public class Model1
    {
        [Key]
        public string keyString { get; set; }

        public string attribute1 { get; set; }
        public string attribute2 { get; set; }
        public string attribute3 { get; set; }
    }
}