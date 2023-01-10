using ArtisanGemstoneIMS.Domain.Common.Models;

namespace ArtisanGemstoneIMS.Domain.OrderAggregate.ValueObjects;

public sealed class OrderItemId : ValueObject
{
    public string Value { get; }

    private OrderItemId(OrderId orderId)
    {
        Value = $"OrderItem_{orderId.Value}";
    }

    private OrderItemId(string value)
    {
        Value = value;
    }

    public static OrderItemId Create(OrderId orderId)
    {
        return new OrderItemId(orderId);
    }

    public static OrderItemId Create(string value)
    {
        return new OrderItemId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}