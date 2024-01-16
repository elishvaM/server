using System;
using System.Collections.Generic;

namespace Entity;

public partial class AttractionListProduct
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public int AttractionListId { get; set; }

    public int Amount { get; set; }

    public int? StatusId { get; set; }

    public virtual AttractionList AttractionList { get; set; } = null!;

    public virtual Product Product { get; set; } = null!;

    public virtual StatusProduct? Status { get; set; }
}
