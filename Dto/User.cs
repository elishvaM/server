using System;
using System.Collections.Generic;

namespace Dto;
public partial class UserLogin
{
    public string Password { get; set; } = "";

    public string Email { get; set; } = "";

}
public partial class FullUser : UserDto
{
    public string Password { get; set; } = "";

}
public partial class UserAndType
{
    public int Id { get; set; }

    public int TypeId { get; set; }
}
public partial class UserDto
{
    public int Id { get; set; }
    
    public string Name { get; set; } = "";

    public string Phone { get; set; } = "";

    public string Email { get; set; } = "";

    public DateTime DateBorn { get; set; }

    public int UserTypeId { get; set; } = 1;

    public bool Status { get; set; }=true;

    public string Type { get; set; } = "";
}
