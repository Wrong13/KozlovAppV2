using System;
using System.Collections.Generic;

namespace KozlovAppV2.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public string? OrderStatus { get; set; }

    public DateTime? OrderDeliveryDate { get; set; }

    public string? OrderPickupPoint { get; set; }

    public virtual ICollection<Product> ProductArticleNumbers { get; } = new List<Product>();
}
