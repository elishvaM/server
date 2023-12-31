﻿using System;
using System.Collections.Generic;

namespace Entity;

public partial class StatusProduct
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<AttractionListProduct> AttractionListProducts { get; set; } = new List<AttractionListProduct>();
}
