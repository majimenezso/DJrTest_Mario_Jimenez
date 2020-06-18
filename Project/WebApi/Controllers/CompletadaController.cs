using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;


namespace WebApi.Controllers
{
    public class CompletadaController : ApiController
    {
        Models.TAREASEntities db = new Models.TAREASEntities();


        [HttpPut]
        public IHttpActionResult Put(int id, Tarea p)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);


            }

            if (id != p.idtarea)
            {
                return BadRequest();


            }

            db.Entry(p).State = EntityState.Modified;

            try
            {

                db.SaveChanges();
            }
            catch (Exception)
            {
                return NotFound();

            }


            return StatusCode(HttpStatusCode.NoContent);
        }

    }
}
