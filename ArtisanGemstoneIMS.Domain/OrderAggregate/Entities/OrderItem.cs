using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.Common.ValueObjects;
using ArtisanGemstoneIMS.Domain.OrderAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.OrderAggregate.Entities;

public sealed class OrderItem : Entity<OrderItemId>
{
    public OrderId OrderId { get; }
    public ProductOrdered ProductOrdered { get; }
    public Price UnitPrice { get; }
    public int Units { get; }

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private OrderItem(
        OrderId orderId,
        ProductOrdered productOrdered,
        Price unitPrice,
        int units)
        : base(OrderItemId.Create(orderId))
    {
        OrderId = orderId;
        ProductOrdered = productOrdered;
        UnitPrice = unitPrice;
        Units = units;
    }

    public static OrderItem Create(
        OrderId orderId,
        ProductOrdered productOrdered,
        Price unitPrice,
        int units)
    {
        return new OrderItem(
            orderId,
            productOrdered,
            unitPrice,
            units);
    }
}