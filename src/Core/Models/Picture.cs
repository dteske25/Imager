using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Picture : BaseMongoObject
    {
        public byte[] Data { get; set; }
        public string Title { get; set; }
        public DateTime UploadDate { get; set; }
        public string ContentType { get; set; }
    }
}
