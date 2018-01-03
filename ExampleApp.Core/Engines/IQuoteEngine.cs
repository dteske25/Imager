using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Core.Dtos;
using ExampleApp.Core.Models;

namespace ExampleApp.Core.Engines
{
    public interface IQuoteEngine
    {
        Task<QuoteDto> Create(string text, string firstName, string lastName, DateTime date);
        Task<IEnumerable<QuoteDto>> Search(string fragment);
        Task<IEnumerable<QuoteDto>> GetAll();
        Task Delete(string id);
        Task<QuoteDto> Update(string id, string text);

    }
}
