using ArtisanGemstoneIMS.Domain.Common.Models;
using ArtisanGemstoneIMS.Domain.InventoryAggregate.ValueObjects;
using ArtisanGemstoneIMS.Domain.ProductAggregate;
using ArtisanGemstoneIMS.Domain.ProductAggregate.ValueObjects;

namespace ArtisanGemstoneIMS.Domain.InventoryAggregate;

public sealed class Inventory : AggregateRoot<InventoryId>
{
    public ProductId ProductId { get; }
    public Product Product { get; private set; } = null!;
    public int QuantityOnHand { get; }
    public int IdealQuantity { get; }

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Inventory(
        InventoryId inventoryId,
        ProductId productId,
        int quantityOnHand,
        int idealQuantity)
        : base(inventoryId)
    {
        ProductId = productId;
        QuantityOnHand = quantityOnHand;
        IdealQuantity = idealQuantity;
    }

    public static Inventory Create(
        ProductId productId,
        int quantityOnHand,
        int idealQuantity)
    {
        return new Inventory(
            InventoryId.CreateUnique(),
            productId,
            quantityOnHand,
            idealQuantity);
    }
}