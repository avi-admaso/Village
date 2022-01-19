using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Village.Models;

namespace Village.Controllers
{
    public class SettlerController : ApiController
    {
        // GET: api/Settler
        public VillageDC DbContext = new VillageDC();
        public IHttpActionResult Get()
        {
            try
            {

                return Ok(DbContext.Settlers.ToList());
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        // GET: api/Settler/5
        public IHttpActionResult Get(int id)
        {
            try
            {

                Settler setllerId = DbContext.Settlers.First(settler => settler.Id == id);
                return Ok(setllerId);
            }
            catch (SqlException x)
            {

                return BadRequest(x.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        // POST: api/Settler
        public IHttpActionResult Post([FromBody] Settler value)
        {
            try
            {
                DbContext.Settlers.Add(value);
                DbContext.SaveChanges();
                return Ok("you good");

            }
            catch (SqlException x)
            {

                return BadRequest(x.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
        }

        // PUT: api/Settler/5
        public IHttpActionResult Put(int id, [FromBody] Settler value)
        {
            try
            {
                Settler putById = DbContext.Settlers.First(setller => setller.Id == id);
                putById.Name = value.Name;
                putById.FatherName = value.FatherName;
                putById.Gender = value.Gender;
                putById.BornOnVillage = value.BornOnVillage;
                putById.DateTime = value.DateTime;
                DbContext.SaveChanges();
                return Ok("good job");

            }
            catch (SqlException x)
            {

                BadRequest(x.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
            return Ok("you good");
        }

        // DELETE: api/Settler/5
        public IHttpActionResult Delete(int id)
        {
            try
            {

                DbContext.Settlers.Remove(DbContext.Settlers.First(settler => settler.Id == id));
                DbContext.SaveChanges();
                return Ok("the item delete");
            }
            catch (SqlException x)
            {

                BadRequest(x.Message);
            }
            catch (Exception x)
            {
                return BadRequest(x.Message);
            }
            return Ok("you good");
        }
    }
}
