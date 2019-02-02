using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using EFCoreTest.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTest.Controllers {

    [Route("api/[controller]")]
    public class OrdersController : Controller {
        NorthwindContext context = new NorthwindContext();
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            IQueryable<Order> data = context.Orders.OrderBy(i => i.ShipCountry); //pre-defined settings
            var res1 = data.OrderBy(i => i.OrderID).Skip(0).Take(200).ToList(); //plain query

            return DataSourceLoader.Load(context.Orders, loadOptions);
        }

    }
}