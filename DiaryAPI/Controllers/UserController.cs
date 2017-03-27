using DiaryAPI.Models;
using Swashbuckle.Swagger.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DiaryAPI.Controllers
{
    public class UserController : ApiController
    {
        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public bool Post([FromBody]Account value)
        {
            if(value.uid == "admin" && value.h_pwd == "123")
            {
                return true;
            }

            return false;
        }

        public User Get()
        {
            User u = new Models.User();
            u.id = Guid.NewGuid().ToString();
            u.name = "user1";
            u.photo_url = "";
            u.role = DiaryRoles.Parent;
            u.surname = "user1";
            return u;
        }
    }
}
