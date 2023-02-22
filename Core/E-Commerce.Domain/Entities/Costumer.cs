using E_Commerce.Domain.Entities.Common;

namespace E_Commerce.Domain.Entities;

public class Costumer : BaseEntity
{
    public string Name { get; set; }

    public ICollection<Order> Orders { get; set; }
}
