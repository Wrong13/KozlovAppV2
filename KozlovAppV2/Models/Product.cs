using System;
using System.Collections.Generic;

namespace KozlovAppV2.Models;

public partial class Product
{
    public string ProductArticleNumber { get; set; } = null!;

    public string? ProductName { get; set; }

    public string? ProductDescription { get; set; }

    public string? ProductCategory { get; set; }

    public byte[]? ProductPhoto { get; set; }

    public string? ProductManufacturer { get; set; }

    public decimal? ProductCost { get; set; }

    public byte? ProductDiscountAmount { get; set; }

    public int? ProductQuantityInStock { get; set; }

    public string? ProductStatus { get; set; }

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
