using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class User:IdentityUser,IUser
    {
        public ICollection<LabTest>? LabTests { get; set; }
    }
}
