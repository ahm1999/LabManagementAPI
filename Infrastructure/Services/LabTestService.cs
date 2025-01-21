

using Application.Common;
using Application.DTOs.LabTestDTOs;
using Application.ServiceInterfaces;
using Domain.Entities;
using Infrastructure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Services
{
    public class LabTestService : ILabTestService
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationDBContext _context;
        private readonly IHttpContextAccessor _accessor;

        public LabTestService(UserManager<User> userManager,ApplicationDBContext context,IHttpContextAccessor accessor)
        {
            _userManager = userManager;
            _context = context;
            _accessor = accessor;   
        }
        public async Task<ServiceResponse<LabTest>> AddTest(CreateLabTestDTO createLabTestDTO)
        {
            string UserId = _userManager.GetUserId(_accessor.HttpContext.User)??Guid.Empty.ToString();
            LabTest labTest = new LabTest()
            {
                TestName = createLabTestDTO.TestName,
                CreatedOn = DateOnly.FromDateTime(DateTime.Now),
                UserId = UserId
            };


            await _context.LabTests.AddAsync(labTest);
            await _context.SaveChangesAsync();


            return new ServiceResponse<LabTest>(true, "Test Added Succesfully", labTest);
        }
    }
}
