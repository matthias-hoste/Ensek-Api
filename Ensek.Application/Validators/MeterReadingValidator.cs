using Ensek.Application.Validators.Interfaces;
using Ensek.Domain.Models;
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace Ensek.Application.Validators
{
    internal class MeterReadingValidator : IValidateMeterReading
    {
        public bool IsValid(MeterReading meterReading)
        {
            return Regex.IsMatch(meterReading.Value.ToString(), @"^\d{1,5}$");
        }
    }
}