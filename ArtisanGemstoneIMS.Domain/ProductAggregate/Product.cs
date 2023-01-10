using ArtisanGemstoneIMS.Domain.CategoryAggregate;
using ArtisanGemstoneIMS.Domain.CategoryAggregate.ValueObjects;
using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.ProductAggregate.Entities;
using ArtisanGemstoneIMS.Domain.ProductAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.ProductAggregate;

public sealed class Product : AggregateRoot<ProductId>
{
    private readonly List<Variation> _variations = new();

    public string Name { get; }
    public string Description { get; }
    public string ImageUrl { get; }
    public bool IsArchived { get; }
    public CategoryId CategoryId { get; }
    public Category Category { get; private set; } = null!;

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    public IReadOnlyList<Variation> Variations => _variations.ToList();

    private Product(
        ProductId productId,
        string name,
        string description,
        string imageUrl,
        bool isArchived,
        CategoryId categoryId)
        : base(productId)
    {
        Name = name;
        Description = description;
        ImageUrl = imageUrl;
        IsArchived = isArchived;
        CategoryId = categoryId;
    }

    public static Product Create(
        string name,
        string description,
        string imageUrl,
        bool isArchived,
        CategoryId categoryId)
    {
        return new Product(
            ProductId.CreateUnique(),
            name,
            description,
            imageUrl,
            isArchived,
            categoryId);
    }
}