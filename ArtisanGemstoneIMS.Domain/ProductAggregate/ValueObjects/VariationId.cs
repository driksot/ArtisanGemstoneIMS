using ArtisanGemstoneIMS.Domain.Common.Models;

namespace ArtisanGemstoneIMS.Domain.ProductAggregate.ValueObjects;

public sealed class VariationId : ValueObject
{
    public string Value { get; }

    private VariationId(ProductId productId)
    {
        Value = $"Variation_{productId.Value}";
    }

    private VariationId(string value)
    {
        Value = value;
    }

    public static VariationId Create(ProductId productId)
    {
        return new VariationId(productId);
    }

    public static VariationId Create(string value)
    {
        return new VariationId(value);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}