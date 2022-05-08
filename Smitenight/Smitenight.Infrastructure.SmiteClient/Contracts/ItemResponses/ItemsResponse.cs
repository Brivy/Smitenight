﻿using System.Text.Json.Serialization;

namespace Smitenight.Infrastructure.SmiteClient.Contracts.ItemResponses
{
    public record class ItemsResponse
    (
        [property: JsonPropertyName("ActiveFlag")] string ActiveFlag,
        [property: JsonPropertyName("ChildItemId")] int ChildItemId,
        [property: JsonPropertyName("DeviceName")] string DeviceName,
        [property: JsonPropertyName("Glyph")] string Glyph,
        [property: JsonPropertyName("IconId")] int IconId,
        [property: JsonPropertyName("ItemDescription")] ItemDescription ItemDescription,
        [property: JsonPropertyName("ItemId")] int ItemId,
        [property: JsonPropertyName("ItemTier")] int ItemTier,
        [property: JsonPropertyName("Price")] int Price,
        [property: JsonPropertyName("RestrictedRoles")] string RestrictedRoles,
        [property: JsonPropertyName("RootItemId")] int RootItemId,
        [property: JsonPropertyName("ShortDesc")] string ShortDesc,
        [property: JsonPropertyName("StartingItem")] bool StartingItem,
        [property: JsonPropertyName("Type")] string Type,
        [property: JsonPropertyName("itemIcon_URL")] string ItemIconUrl,
        [property: JsonPropertyName("ret_msg")] object RetMsg
    );

    public record class ItemDescription
    (
        [property: JsonPropertyName("Description")] string Description,
        [property: JsonPropertyName("Menuitems")] MenuItem[] MenuItems,
        [property: JsonPropertyName("SecondaryDescription")] object SecondaryDescription
    );

    public record class MenuItem
    (
        [property: JsonPropertyName("Description")] string Description,
        [property: JsonPropertyName("Value")] string Value
    );
}
