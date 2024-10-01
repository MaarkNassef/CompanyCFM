using System;
using System.Collections.Generic;

namespace CompanyCFM.Models;

public partial class Order
{
    public string Id { get; set; } = null!;

    public string? CustomerId { get; set; }

    public int? ProductId { get; set; }

    public int? Amount { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Product? Product { get; set; }
}
