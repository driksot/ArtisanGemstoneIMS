namespace ArtisanGemstoneIMS.Contracts.Products;

public record ProductResponse(
	string Id,
	string Name,
	string Description,
	string ImageUrl,
	string CategoryName,
	List<VariationResponse> Variations,
	DateTime CreatedDateTime,
    DateTime UpdatedDateTime);

public record VariationResponse(
	string Id,
	string Size,
	PriceResponse Price,
	DateTime CreatedDateTime,
	DateTime UpdatedDateTime);

public record PriceResponse(
	decimal Amount,
	string Currency);