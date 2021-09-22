using Ensek.Application.Commands.InsertMeterReadings;
using ExcelDataReader;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace Ensek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeterController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MeterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("meter-readings-uploads")]
        public async Task<InsertMeterReadingsResponse> UploadMeterReadings([FromForm] IFormFile csvFile, CancellationToken token)
        {
            using (var stream = csvFile.OpenReadStream())
            using (var excelReader = ExcelReaderFactory.CreateReader(stream))
            {
                var dataSet = excelReader.AsDataSet();
                var dataTable = dataSet.Tables[0];

                return await _mediator.Send(new InsertMeterReadingsCommand()
                {
                    DataTable = dataTable
                }, token);
            }
        }
    }
}
