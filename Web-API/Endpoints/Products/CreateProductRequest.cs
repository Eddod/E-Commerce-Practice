﻿namespace Web_API.Endpoints.Products;

public sealed record CreateProductRequest(
    string Name,
    string Sku,
    string Currency,
    decimal Amount);


