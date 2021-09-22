using Ensek.Application.Mappers;
using Ensek.Application.Validators.Interfaces;
using Ensek.Domain.Models;
using Ensek.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Ensek.Application.Commands.InsertMeterReadings
{
    public class InsertMeterReadingsCommandHandler : IRequestHandler<InsertMeterReadingsCommand, InsertMeterReadingsResponse>
    {
        private readonly EnsekDbContext _dbContext;
        private readonly IValidateMeterReading _meterReaderValidator;

        public InsertMeterReadingsCommandHandler(EnsekDbContext dbContext, IValidateMeterReading meterReaderValidator)
        {
            _dbContext = dbContext;
            _meterReaderValidator = meterReaderValidator;
        }

        public async Task<InsertMeterReadingsResponse> Handle(InsertMeterReadingsCommand request, CancellationToken cancellationToken)
        {
            var successfullReadings = 0;

            foreach (DataRow dataRow in request.DataTable.Rows)
            {
                if (!int.TryParse(Convert.ToString(dataRow[0]), out var accountId))
                    continue;

                var account = await _dbContext.Accounts.Include(x => x.MeterReadings).FirstOrDefaultAsync(x => x.Id == accountId);

                if (account != null)
                {
                    var meterReading = dataRow.MapTo<MeterReading>();

                    if (meterReading != null && _meterReaderValidator.IsValid(meterReading))
                    {
                        if(account.AddMeterReading(meterReading))
                            successfullReadings++;
                    }
                }
            }

            await _dbContext.SaveChangesAsync();

            return new InsertMeterReadingsResponse
            {
                Success = successfullReadings,
                Failed = request.DataTable.Rows.Count - successfullReadings
            };
        }

    }
}