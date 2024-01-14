// ReSharper disable UnusedAutoPropertyAccessor.Global
namespace Contracts.Features.Cocktails.GetCocktails;

public sealed class GetCocktailsRequestDto
{
    public string? SearchValue { get; init; }
}