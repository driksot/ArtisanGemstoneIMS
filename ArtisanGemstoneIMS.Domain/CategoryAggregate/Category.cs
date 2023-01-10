using ArtisanGemstoneIMS.Domain.CategoryAggregate.ValueObjects;
using ArtisanGemstoneIMS.Domain.Common.Models;

namespace ArtisanGemstoneIMS.Domain.CategoryAggregate;

public sealed class Category : AggregateRoot<CategoryId>
{
    public string Name { get; }
    public string Description { get; }
    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Category(
        CategoryId categoryId,
        string name,
        string description)
        : base(categoryId)
    {
        Name = name;
        Description = description;
    }

    public static Category Create(
        string name,
        string description)
    {
        return new Category(
            CategoryId.CreateUnique(),
            name,
            description);
    }
}