using ArtisanGemstoneIMS.Domain.Common.Models;

namespace ArtisanGemstoneIMS.Domain.CategoryAggregate.ValueObjects;

public sealed class CategoryId : ValueObject
{
    public Guid Value { get; }

    private CategoryId(Guid value)
    {
        Value = value;
    }

    public static CategoryId CreateUnique()
    {
        return new CategoryId(Guid.NewGuid());
    }

    public static CategoryId Create(Guid value)
    {
        return new CategoryId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}