using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Models;
using Shared.Interfaces;

namespace BeuticianBusiness
{
    public class AdminBusiness : IAdminBusiness
    {

        private readonly IAdminRepository adminRepository;

        public AdminBusiness(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public List<Admin> GetAdmins()
        {
            return this.adminRepository.GetAdmins();
        }


        public bool AdminLoginValidation(string username, string password)
        {
            List<Admin> admins = GetAdmins();


            foreach (Admin admin in admins)
            {
                if (admin.Username == username && admin.Password == password)
                    return true;

            }

            return false;


        }
    }
}
