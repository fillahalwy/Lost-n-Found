using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_n_Found.Controllers
{
    internal static class CurrentUser
    {
        public static string UserId { get; set; }
        public static string Name { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Email { get; set; }
        public static string Address { get; set; }
        public static string Image { get; set; }
        public static string Gender { get; set; }
        public static string Phone { get; set; }

        public static void ClearUser()
        {
            CurrentUser.UserId = null;
            CurrentUser.Username = null;
            CurrentUser.Password = null;
            CurrentUser.Name = null;
            CurrentUser.Email = null;
            CurrentUser.Address = null;
            CurrentUser.Image = null;
            CurrentUser.Gender = null;
            CurrentUser.Phone = null;
        }
    }

}
