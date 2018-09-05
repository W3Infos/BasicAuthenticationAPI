using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using System.Web.Http.Cors;
using System.Threading;

namespace BasicAuthenticationAPI.Controllers
{
    [EnableCorsAttribute("*","*","*")]
    public class UsersController : ApiController
    {
        [BasicAuthentication]
        public HttpResponseMessage Get()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;

            using (mmb_dbEntities entities = new mmb_dbEntities())
            {
                //return entities.Users.ToList();
                return Request.CreateResponse(HttpStatusCode.OK, entities.Users.ToList());

            }
        }
    }
}
