using System;
using System.Collections.Generic;

namespace Dto;

public partial class AttractionDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Img { get; set; } = null!;

    public string WebsiteAddress { get; set; } = null!;

    //public int CountryId { get; set; }

    public bool IsConfirm { get; set; }

    //public int TypeId { get; set; }

    //public int AddressId { get; set; }

    public bool Status { get; set; }

    //public int PersonStateId { get; set; }

    public AddressDto Address { get; set; }

    public PersonStateDto PersonState { get; set; } = null!;

    public AttractionTypeDto Type { get; set; } = null!;


}
