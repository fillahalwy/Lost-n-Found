using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lost_n_Found.Models.Entity
{
    internal class Users
    {
        public int Id_User { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address {  get; set; }
        public string Image_Profile { get; set; }
        public int Gender { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
        public string reset_token { get; set; }
        public DateTime token_expiry { get; set; }
    }
}
