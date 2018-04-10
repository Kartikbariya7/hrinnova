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
    public class AllHolidayListController : ApiController
    {
        [HttpPost]
        [JwtAuthentication]
        //HolidayList emp
        public IHttpActionResult GetHolidayListDetails(HolidayList1 emp)
        {
            var response_from_holiday = AllHolidayRepository.GetHolidayListDetails(emp.EmpID);
            var response = WebMethods.CreateServiceResponse(Enums.WebServiceStatus.Success, response_from_holiday);
            return Json(response);
        }
    }
}
