using Ensek.Domain.Models;
using System;
using System.Data;

namespace Ensek.Application.Mappers
{
    public static class DataRowMapper
    {
        public static MeterReading MapTo<T>(this DataRow dataRow) where T : MeterReading
        {
            if (!DateTimeOffset.TryParse(Convert.ToString(dataRow[1]), out var date)
                || !long.TryParse(Convert.ToString(dataRow[2]), out var value))
                return null;

            return new MeterReading
            {
                Date = date,
                Value = value
            };
        }
    }
}