using MediatR;
using System.Data;

namespace Ensek.Application.Commands.InsertMeterReadings
{
    public class InsertMeterReadingsCommand : IRequest<InsertMeterReadingsResponse>
    {
        public DataTable DataTable { get; set; }
    }
}