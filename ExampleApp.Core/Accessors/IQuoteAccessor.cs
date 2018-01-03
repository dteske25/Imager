using System;
using System.Collections.Generic;
using System.Text;
using ExampleApp.Core.Models;

namespace ExampleApp.Core.Accessors
{
    public interface IQuoteAccessor: IMongoAccessor<Quote> 
    {
    }
}
