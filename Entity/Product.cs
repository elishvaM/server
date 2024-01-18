using System;
using System.Collections.Generic;

namespace Entity;

public partial class Product
{
    public int Id { get; set; }

    public bool IsDuplicated { get; set; }

    public int ProductTypeId { get; set; }

    public int StorageTypeId { get; set; }

    public bool IsNeedAssurants { get; set; }

    public string Img { get; set; } = null!;

    public bool IsImgConfirm { get; set; }

    public bool IsConfirm { get; set; }

    public int? UserId { get; set; }

    public string Name { get; set; } = null!;

    public bool? Status { get; set; }

    public virtual ICollection<AttractionListProduct> AttractionListProducts { get; set; } = new List<AttractionListProduct>();

    public virtual ProductType ProductType { get; set; } = null!;

    public virtual StorageType StorageType { get; set; } = null!;
}
