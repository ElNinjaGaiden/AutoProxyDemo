using System;
using System.Web.Http;
using AutoProxy.Annotations;
using AutoProxyDemo.Models;

namespace AutoProxyDemo.Controllers
{
    [AutoProxyIgnore]
    public class OrdersController : ApiController
    {
        public void Post(Order order)
        {
            throw  new NotImplementedException();
        }
    }
}
