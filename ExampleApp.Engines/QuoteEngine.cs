using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleApp.Core.Accessors;
using ExampleApp.Core.Dtos;
using ExampleApp.Core.Engines;
using ExampleApp.Core.Models;

namespace ExampleApp.Engines
{
    public class QuoteEngine : IQuoteEngine
    {
        private readonly IQuoteAccessor _quoteAccessor;

        public QuoteEngine(IQuoteAccessor quoteAccessor)
        {
            _quoteAccessor = quoteAccessor;
        }
        
        public async Task<QuoteDto> Create(string text, string firstName, string lastName, DateTime date)
        {
            var result = await _quoteAccessor.Insert(new Quote
            {
                Text = text,
                FirstName = firstName,
                LastName = lastName,
                Date = date
            });
            return result.ToDto();
        }

        public async Task Delete(string id)
        {
            var toDelete = await _quoteAccessor.First(q => q.Id == id);
            await _quoteAccessor.Delete(toDelete);
        }

        public async Task<IEnumerable<QuoteDto>> GetAll()
        {
            var results = await _quoteAccessor.GetAll();
            return results.Select(r => r.ToDto());
        }

        public async Task<IEnumerable<QuoteDto>> Search(string fragment)
        {
            var results = await _quoteAccessor.Find(q => q.Text.Contains(fragment));
            return results.Select(r => r.ToDto());
        }

        public async Task<QuoteDto> Update(string id, string text)
        {
            var result = await _quoteAccessor.First(q => q.Id == id);
            result.Text = text;
            await _quoteAccessor.Update(result);
            return result.ToDto();
        }
    }
}
