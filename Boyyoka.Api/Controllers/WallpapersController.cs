using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Boyyoka.Api;

namespace Boyyoka.Api.Controllers
{
    public class WallpapersController : ApiController
    {
        private BoyyoyoContext db = new BoyyoyoContext();

        // GET: api/Wallpapers
        public IQueryable<Wallpaper> GetWallpapers()
        {
            return db.Wallpapers.Take(10);
        }

        // GET: api/Wallpapers/5
        [ResponseType(typeof(Wallpaper))]
        public async Task<IHttpActionResult> GetWallpaper(int id)
        {
            Wallpaper wallpaper = await db.Wallpapers.FindAsync(id);
            if (wallpaper == null)
            {
                return NotFound();
            }

            return Ok(wallpaper);
        }

        // GET: api/Recent
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        [Route("api/Wallpapers/Recent")]
        public IQueryable<Wallpaper> Recent()
        {
         
            return db.Wallpapers.OrderByDescending(w => w.Date).Take(10);
        }

        /*
        // PUT: api/Wallpapers/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutWallpaper(int id, Wallpaper wallpaper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != wallpaper.WallpaperID)
            {
                return BadRequest();
            }

            db.Entry(wallpaper).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WallpaperExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

    */
        /*
            // POST: api/Wallpapers
            [ResponseType(typeof(Wallpaper))]
            public async Task<IHttpActionResult> PostWallpaper(Wallpaper wallpaper)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Wallpapers.Add(wallpaper);
                await db.SaveChangesAsync();

                return CreatedAtRoute("DefaultApi", new { id = wallpaper.WallpaperID }, wallpaper);
            }
            */
        /*
        // DELETE: api/Wallpapers/5
        [ResponseType(typeof(Wallpaper))]
        public async Task<IHttpActionResult> DeleteWallpaper(int id)
        {
            Wallpaper wallpaper = await db.Wallpapers.FindAsync(id);
            if (wallpaper == null)
            {
                return NotFound();
            }

            db.Wallpapers.Remove(wallpaper);
            await db.SaveChangesAsync();

            return Ok(wallpaper);
        }
        */
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WallpaperExists(int id)
        {
            return db.Wallpapers.Count(e => e.WallpaperID == id) > 0;
        }
    }
}