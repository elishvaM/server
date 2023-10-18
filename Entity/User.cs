using System;
using System.Collections.Generic;

namespace Entity;

public partial class User
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public DateTime DateBorn { get; set; }

    public int UserTypeId { get; set; }

    public bool Status { get; set; }

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual ICollection<SavedAttraction> SavedAttractions { get; set; } = new List<SavedAttraction>();

    public virtual UserType UserType { get; set; } = null!;
}
