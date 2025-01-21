using Application.Common;
using Application.DTOs.LabTestDTOs;
using Domain.Entities;


namespace Application.ServiceInterfaces
{
    public interface ILabTestService
    {
        Task<ServiceResponse<LabTest>> AddTest(CreateLabTestDTO createLabTestDTO);
    }
}
