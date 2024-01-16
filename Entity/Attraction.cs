using System;
using System.Collections.Generic;

namespace Entity;

public partial class Attraction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Img { get; set; } = null!;

    public string? Img2 { get; set; }

    public string? Img3 { get; set; }

    public string WebsiteAddress { get; set; } = null!;

    public int CountryId { get; set; }

    public bool IsConfirm { get; set; }

    public int TypeId { get; set; }

    public int AddressId { get; set; }

    public bool Status { get; set; }

    public int PersonStateId { get; set; }

    public virtual Address Address { get; set; } = null!;

    public virtual ICollection<AttractionList> AttractionLists { get; set; } = new List<AttractionList>();

    public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

    public virtual ICollection<OpeningHour> OpeningHours { get; set; } = new List<OpeningHour>();

    public virtual PersonState PersonState { get; set; } = null!;

    public virtual ICollection<SavedAttraction> SavedAttractions { get; set; } = new List<SavedAttraction>();

    public virtual AttractionType Type { get; set; } = null!;
}
