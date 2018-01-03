using System;
using System.Collections.Generic;
using System.Text;
using ExampleApp.Core.Dtos;
using ExampleApp.Core.Models;

namespace ExampleApp.Engines
{
    public static class MappingExtensions
    {
        public static QuoteDto ToDto(this Quote obj)
        {
            if (obj == null) return null;
            return new QuoteDto
            {
                Id = obj.Id ?? null,
                FirstName = obj.FirstName,
                LastName = obj.LastName,
                Date = obj.Date,
                Text = obj.Text
            };
        }

        public static Quote ToBaseObject(this QuoteDto dto)
        {
            if (dto == null) return null;
            return new Quote
            {
                Id = dto.Id ?? null,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Date = dto.Date,
                Text = dto.Text
            };
        }
    }
}
