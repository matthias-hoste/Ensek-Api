using System;

namespace Ensek.Domain.Models
{
    public class MeterReading
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public long Value { get; set; }
    }
}