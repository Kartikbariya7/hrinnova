using HRInnova.Data.Repository;
using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPi_HRInnova.AppCode;
using WebAPi_HRInnova.Helpers;

namespace ProductsApp.Controllers
{
    public class BotAuthenticationController : ApiController
    {
        [HttpPost]
        public IHttpActionResult BotAuthenticationDetails(BotAuthenticationModal id)
        {

            BotAuthenticationRepository sa = new BotAuthenticationRepository();
            var r = sa.GetLoginDetails(id.loginID,id.password);

            var response = WebMethods.CreateServiceResponse(Enums.WebServiceStatus.Success, r);
            return Json(response);

        }
    }
}
