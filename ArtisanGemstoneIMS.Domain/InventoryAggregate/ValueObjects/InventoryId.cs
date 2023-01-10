using ArtisanGemstoneIMS.Domain.Common.Models;

namespace ArtisanGemstoneIMS.Domain.InventoryAggregate.ValueObjects;

public sealed class InventoryId : ValueObject
{
    public Guid Value { get; }

    private InventoryId(Guid value)
    {
        Value = value;
    }

    public static InventoryId CreateUnique()
    {
        return new InventoryId(Guid.NewGuid());
    }

    public static InventoryId Create(Guid value)
    {
        return new InventoryId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}