
using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.LabTestDTOs
{
    public class CreateLabTestDTO
    {
        [Required]
        public string? TestName { get; set; }

      
    }
}
