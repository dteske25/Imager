using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using Core.Interfaces;
using Core.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        IPictureAccessor _pictureAccessor;
        public ImageController(IPictureAccessor pictureAccessor)
        {
            _pictureAccessor = pictureAccessor;
        }
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

            _pictureAccessor.Insert(new Picture()
            {
                Data = image,
                UploadDate = DateTime.UtcNow,
                Title = file.FileName,
                ContentType = file.ContentType,
            });

            return Json("Success");
        }

        [HttpGet]
        public JsonResult Index()
        {
            return Json("Up and running");
        }

        [HttpGet("_all")]
        public JsonResult Get()
        {
            return Json(_pictureAccessor.GetAllTitles());
        }

        [HttpGet("{title}")]
        public FileContentResult Get([FromRoute]string title)
        {
            var picture = _pictureAccessor.Find(p => p.Title == title).Single();
            return new FileContentResult(picture.Data, picture.ContentType);
        }
    }
}
