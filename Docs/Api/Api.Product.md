# Artisan Gemstone IMS API

- [Artisan Gemstone IMS API](#artisan-gemstone-ims-api)
  - [Product](#product)
    - [Create Product](#create-product)
      - [Create Product Request](#create-product-request)
      - [Create Product Response](#create-product-response)

## Product

### Create Product

#### Create Product Request

```js
POST /products
```

```json
{
    "name": "Agate",
    "description": "A decorative gemstone.",
    "imageUrl": "images/agate.png",
    "categoryId": "00000000-0000-0000-0000-000000000000"
}
```

#### Create Product Response

```js
201 Created
```

```json
{
    "id": "00000000-0000-0000-0000-000000000000",
    "name": "Agate",
    "description": "A decorative gemstone.",
    "imageUrl": "images/agate.png",
    "categoryName": "Gemstone",
    "variations": [],
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z"
}
```
