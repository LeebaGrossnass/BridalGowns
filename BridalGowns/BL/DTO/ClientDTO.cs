using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BL.DTO;


public class ClientDTO
{
    [JsonConstructor]
    
    public ClientDTO() { }
    public ClientDTO(string id, string firstName, string lastName, string phonNumber, string email)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.PhoneNumber = phonNumber;
        this.Email = email;
    }
    public string Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string PhoneNumber { get; set; }

    public string Email { get; set; }

    public virtual ICollection<MeetingDTO> Meetings { get; set; } = new List<MeetingDTO>();

    public virtual ICollection<OrderDTO> Orders { get; set; } = new List<OrderDTO>();
}
