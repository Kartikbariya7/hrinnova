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

namespace ProductsApp.Controllers.Attendance_Payroll
{
    public class Probation_PeriodController : ApiController
    {

        [JwtAuthentication]
        [HttpPost]
        public IHttpActionResult Probation_period_details(Probation_periodModal id)
        {
            
            Profile_Prob_JoinRepository sa = new Profile_Prob_JoinRepository();
            var r = sa.GetProfileDetails(id.empID);

             var response = WebMethods.CreateServiceResponse(Enums.WebServiceStatus.Success, r);
            return Json(response);


        }
    }
}
