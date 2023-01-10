namespace ArtisanGemstoneIMS.Contracts.Products;

public record CreateProductRequest(
	string Name,
	string Description,
	string ImageUrl,
	string CategoryId);