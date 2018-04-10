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
    public class OptionalHolidayController : ApiController
    {
        [HttpPost]
        [JwtAuthentication]
        public IHttpActionResult GetOptionalHolidayListDetails(OptionalHolidayList emp)
        {
            var response_from_holiday = OptionalHolidayRepository.GetOptionalHolidayListDetails(emp.EmpID);
            var response = WebMethods.CreateServiceResponse(Enums.WebServiceStatus.Success, response_from_holiday);
            return Json(response);
        }
    }
}
