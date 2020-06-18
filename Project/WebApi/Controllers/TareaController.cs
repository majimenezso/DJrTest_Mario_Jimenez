using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.UI.HtmlControls;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class TareaController : ApiController
    {


        Models.TAREASEntities db = new Models.TAREASEntities();


        [HttpPost]
        public IHttpActionResult Entrada(Models.Request.ProductoView model)
        {

            using (Models.TAREASEntities db = new Models.TAREASEntities())
            {

                var tarea = new Models.Tarea();
                tarea.nombre = model.nombre;
                db.Tarea.Add(tarea);
                db.SaveChanges();

            }

            return Ok("post exitoso");
        }


      

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
            catch (Exception )
            {
                return NotFound();
                
            }

            
            return StatusCode(HttpStatusCode.NoContent);
        }


        [HttpGet]

        public IHttpActionResult Get()
        {

            List<WebApi.Models.Request.ProductoView> lt = new List<Models.Request.ProductoView>();

            using (Models.TAREASEntities db = new Models.TAREASEntities())
            {
                lt = (from d in db.Tarea
                      select new Models.Request.ProductoView
                      {
                      
                         
                          nombre = d.nombre
                         


                      }).ToList();
            }

            return Ok(lt);
        } 


    }
}





