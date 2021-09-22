using System.Collections.Generic;
using System.Linq;

namespace Ensek.Domain.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<MeterReading> MeterReadings { get; set; } = new List<MeterReading>();

        public bool AddMeterReading(MeterReading meterReading)
        {
            if (MeterReadings.Any(x => x.Value == meterReading.Value))
                return false;

            MeterReadings.Add(meterReading);

            return true;
        }
    }
}