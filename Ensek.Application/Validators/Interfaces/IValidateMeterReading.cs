using Ensek.Domain.Models;
using System.Data;

namespace Ensek.Application.Validators.Interfaces
{
    public interface IValidateMeterReading
    {
        bool IsValid(MeterReading meterReading);
    }
}