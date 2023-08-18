﻿using Domain.Entities.Orders;
using Domain.Entities.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Configuration;

internal class LineItemConfiguration : IEntityTypeConfiguration<LineItem>
{
    public void Configure(EntityTypeBuilder<LineItem> builder)
    {
        builder.HasKey(li => li.Id);

        builder.Property(li=>li.Id).HasConversion(
            lineItemId => lineItemId.Value,
            value=> new LineItemId(value));

        builder.HasOne<Product>()
            .WithMany()
            .HasForeignKey(li => li.ProductId);

        builder.OwnsOne(li => li.Price);
    }
}
