using System.Text;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using TrackMyMacros.Application.Features.DailyLimits.Commands.UpdateDailyLimits;
using TrackMyMacros.Application.Features.DailyLimits.Queries.GetDailyLimits;
using TrackMyMacros.Dtos;

namespace TrackMyMacros.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DeveloperController:ControllerBase
{

        private IWebHostEnvironment _hostEnvironment;

        public DeveloperController(IWebHostEnvironment environment) {
            _hostEnvironment = environment;
        }
    [HttpGet]
    [ProducesResponseType(statusCode:StatusCodes.Status200OK)]
    public async Task<ActionResult> Get()
    {
        var todaysDate = DateTime.Now.ToString("yyyyMMdd");
        var filename = $"log{todaysDate}.txt";
        string path = Path.Combine(_hostEnvironment.ContentRootPath, filename);
        
        using(FileStream logFileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using(StreamReader logFileReader = new StreamReader(logFileStream))
            {
                var x = new StringBuilder();
                while (!logFileReader.EndOfStream)
                {
                    x.AppendLine(logFileReader.ReadLine());
                }
                
                return  File(Encoding.UTF8.GetBytes(x.ToString()), "application/force-download", filename);
            }
            
        
        }
Ok();
    }

}