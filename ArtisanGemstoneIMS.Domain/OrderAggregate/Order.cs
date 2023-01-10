using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.Common.ValueObjects;
using ArtisanGemstoneIMS.Domain.CustomerAggregate.ValueObjects;
using ArtisanGemstoneIMS.Domain.OrderAggregate.Entities;
using ArtisanGemstoneIMS.Domain.OrderAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.OrderAggregate;

public sealed class Order : AggregateRoot<OrderId>
{
    private readonly List<OrderItem> _orderItems = new();

    public CustomerId CustomerId { get; }
    public Address ShipToAddress { get; }
    public DateTime OrderDateTime { get; }

    public IReadOnlyList<OrderItem> OrderItems => _orderItems.ToList();

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Order(
        OrderId orderId,
        CustomerId customerId,
        Address shipToAddress,
        DateTime orderDateTime)
        : base(orderId)
    {
        CustomerId = customerId;
        ShipToAddress = shipToAddress;
        OrderDateTime = orderDateTime;
    }

    public static Order Create(
        CustomerId customerId,
        Address shipToAddress,
        DateTime orderDateTime)
    {
        return new Order(
            OrderId.CreateUnique(),
            customerId,
            shipToAddress,
            orderDateTime);
    }
}