using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class AccessRightDTO
    {
        [JsonConstructor]

        public AccessRightDTO() { }
        public AccessRightDTO(int id,  string email, string password)
        {
            this.Id = id;
            this.Email = email;
            this.Password = password;
        }
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
