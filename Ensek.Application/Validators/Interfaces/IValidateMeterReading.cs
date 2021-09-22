using Ensek.Domain.Models;

namespace Ensek.Application.Validators.Interfaces
{
    public interface IValidateMeterReading
    {
        bool IsValid(MeterReading meterReading);
    }
}