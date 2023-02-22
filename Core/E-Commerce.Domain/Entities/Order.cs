﻿using E_Commerce.Domain.Entities.Common;

namespace E_Commerce.Domain.Entities;

public class Order : BaseEntity
{
    public string Description { get; set; }
    public string Address { get; set; }

    public Guid CostumerId { get; set; }
    public Costumer Costumer { get; set; }
    public ICollection<Product> Products { get; set; }
}
