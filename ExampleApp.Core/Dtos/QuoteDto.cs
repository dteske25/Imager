using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleApp.Core.Dtos
{
    public class QuoteDto
    {
        public string Id { get; set; }
        public string Text { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return $"{FirstName} {LastName}"; } }
        public DateTime Date { get; set; }
    }
}
