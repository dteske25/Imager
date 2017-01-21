using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        // POST api/values
        [HttpPost("upload")]
        public JsonResult Post([FromForm]IFormFile file)
        {
            Debug.WriteLine($"File {file.FileName} Received");
            var stream = file.OpenReadStream();
            byte[] image;
            byte[] buffer = new byte[16 * 1024];
            using (var reader = new BinaryReader(stream))
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                image = ms.ToArray();
            }

            return Json("Success");
        }

        [HttpGet]
        public JsonResult Index()
        {
            return Json("Up and running");
        }

        //[HttpGet("image/{title}")]
        //public IFormFile Get([FromRoute]string title)
        //{
        //}
    }
}
