using Resume.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Services.AuthService.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
