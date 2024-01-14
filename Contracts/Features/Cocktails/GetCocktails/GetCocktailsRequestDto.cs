namespace Contracts.Features.Cocktails.GetCocktails;

public sealed class GetCocktailsRequestDto
{
    public required string SearchValue { get; init; }
}