using Core.Models;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IPictureAccessor : IMongoAccessor<Picture>
    {

        IEnumerable<string> GetAllTitles();
    }
}
