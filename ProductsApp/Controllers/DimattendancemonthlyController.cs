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
    public class DimattendancemonthlyController : ApiController
    {

        [JwtAuthentication]
        [HttpPost]
        public IHttpActionResult DimattendancemonthlyDetails(DimattendancemonthlyModel id)
        {

            DimattendancemonthlyRepository sa = new DimattendancemonthlyRepository();
            var r = sa.GetMonthlyAttendanceDetails(id.EmpID);

            var response = WebMethods.CreateServiceResponse(Enums.WebServiceStatus.Success, r);
            return Json(response);


        }
    }
}
