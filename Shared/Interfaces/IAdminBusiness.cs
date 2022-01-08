using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
namespace Shared.Interfaces
{
    public interface IAdminBusiness
    {
        bool AdminLoginValidation(string username, string password);
        List<Admin> GetAdmins();
    }
}
