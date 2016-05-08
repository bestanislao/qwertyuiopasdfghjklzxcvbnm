using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class LoginRequest
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string FacebookId { get; set; }
    }
}