using Application.Common;
using Application.DTOs.LabTestDTOs;
using Application.ServiceInterfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabTestController : ControllerBase
    {
        private readonly ILabTestService _labTestService;
        public LabTestController(ILabTestService labTestService)
        {
            _labTestService = labTestService;
        }
        [HttpPost]
        public async Task<IActionResult> AddLabTest(CreateLabTestDTO labTestDTO) {

            ServiceResponse<LabTest> serviceResponse = await _labTestService.AddTest(labTestDTO);

            return Ok(serviceResponse);
        } 

    }
}
