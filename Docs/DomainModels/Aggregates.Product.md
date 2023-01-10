# Domain Aggregates

## Product

```csharp
class Product
{
    Product Create();
    Product Get(ProductId productId);
    List<Product> GetAll(PagingParameters pagingParameters);
    void Update(Product product);
    void Archive(ProductId productId);
}
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Agate",
    "description": "A decorative gemstone.",
    "imageUrl": "images/agate.png",
    "categoryId": "00000000-0000-0000-0000-000000000000",
    "variations": [
        {
            "id": "00000000-0000-0000-0000-000000000000",
            "size": "small",
            "price": {
                "amount": 7.99,
                "currency": "USD"
            }
        }
    ],
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z"
}
```
