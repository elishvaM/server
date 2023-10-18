using System;
using System.Collections.Generic;

namespace Dto;

public partial class UserDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DateBorn { get; set; }

    public int UserTypeId { get; set; }

    public bool Status { get; set; }

}
