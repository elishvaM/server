using System;
using System.Collections.Generic;

namespace Dto;

public partial class AttractionDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Img { get; set; } = null!;

    public string? Img2 { get; set; }

    public string? Img3 { get; set; }

    public string WebsiteAddress { get; set; } = null!;

    public bool IsConfirm { get; set; }

    public int TypeId { get; set; }

    public int AddressId { get; set; }

    public bool Status { get; set; }

    public string State { get; set; }

    public string Type { get; set; }

    public int PersonStateId { get; set; }

    public AddressDto Address { get; set; }

    public int CountryId { get; set; }







}
