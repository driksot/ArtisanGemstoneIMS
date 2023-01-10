using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.Common.ValueObjects;
using ArtisanGemstoneIMS.Domain.ProductAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.ProductAggregate.Entities;

public sealed class Variation : Entity<VariationId>
{
    public ProductId ProductId { get; }
    public string Size { get; }
    public Price Price { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Variation(
        ProductId productId,
        string size,
        Price price)
        : base(VariationId.Create(productId))
    {
        ProductId = productId;
        Size = size;
        Price = price;
    }

    public static Variation Create(
        ProductId productId,
        string size,
        Price price)
    {
        return new Variation(
            productId,
            size,
            price);
    }
}