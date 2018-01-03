using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleApp.Core.Models
{
    public interface IBaseMongoObject
    {
        string Id { get; set; }
    }
}
