﻿using System;
using System.Collections.Generic;

namespace Dto;

public partial class AttractionListProductDto
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int AttractionListId { get; set; }

    public int Amount { get; set; }

    public int StatusId { get; set; }
    public ProductDto? Product { get; set; }
    public string? StatusName { get; set; }


}
