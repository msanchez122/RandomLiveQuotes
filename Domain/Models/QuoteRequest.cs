using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public partial class QuoteRequest
    {
        public int Id { get; set; }
        public string QuoteRequested { get; set; }
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public DateTime AddDate { get; set; }
        public char Status { get; set; }
    }
}
