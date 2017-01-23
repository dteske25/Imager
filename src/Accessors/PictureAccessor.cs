using Accessors.Infrastructure;
using Core.Interfaces;
using Core.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accessors
{
    public class PictureAccessor : MongoAccessor<Picture>, IPictureAccessor
    {
        public PictureAccessor(MongoContext context) : base(context)
        {
        }

        public IEnumerable<string> GetAllTitles()
        {
            return AsQueryable().Select(p => p.Title).ToList();
        }
    }
}
