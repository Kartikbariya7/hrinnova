using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPi_HRInnova.Models
{
    public class ServiceRequest<T> where T : class
    {
        public T RequestJSON { get; set; }
    }
}