using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class Quote
    {
        public int Id { get; set; }
        public string QuoteString { get; set; }
        public DateTime Date { get; set; }        
        public DateTime AddDate { get; set; }
        public char Status { get; set; }

    }
}
