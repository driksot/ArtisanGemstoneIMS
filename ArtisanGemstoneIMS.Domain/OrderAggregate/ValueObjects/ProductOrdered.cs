using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.ProductAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.OrderAggregate.ValueObjects;

public sealed class ProductOrdered : ValueObject
{
    public ProductId ProductId { get; }
    public string ProductName { get; }
    public string PictureUrl { get; set; }

    private ProductOrdered(
        ProductId productId,
        string productName,
        string pictureUrl)
    {
        ProductId = productId;
        ProductName = productName;
        PictureUrl = pictureUrl;
    }

    private static ProductOrdered Create(
        ProductId productId,
        string productName,
        string pictureUrl)
    {
        return new ProductOrdered(
            productId, productName, pictureUrl);
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return ProductId;
        yield return ProductName;
        yield return PictureUrl;
    }
}