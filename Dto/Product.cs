using System;
using System.Collections.Generic;

namespace Dto;

public partial class ProductDto
{
    public int Id { get; set; }

    public bool IsDuplicated { get; set; }

    public int ProductTypeId { get; set; }

    public int StorageTypeId { get; set; }

    public string? ProductType { get; set; }//add field

    public string? StorageType { get; set; }//add field

    public bool IsNeedAssurants { get; set; }

    public string Img { get; set; } = null!;

    public bool IsImgConfirm { get; set; }

    public bool IsConfirm { get; set; }

    public int? UserId { get; set; } 

    public string Name { get; set; } = null!;

    public bool Status { get; set; }

}
