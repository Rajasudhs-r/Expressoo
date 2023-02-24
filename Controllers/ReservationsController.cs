using Expressoo.Data;
using Expressoo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Expressoo.Controllers
{
    public class ReservationsController : ApiController
    {
        ExpressoDbContext expreesoDbcontext = new ExpressoDbContext();

        public IHttpActionResult Post(Reservation reservation)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            expreesoDbcontext.Reservations.Add(reservation);
            expreesoDbcontext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
    }
}
