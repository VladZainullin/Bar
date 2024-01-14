namespace Contracts.Features.Cocktails.GetCocktail;

public sealed class GetCocktailResponseDto
{
    public required Guid Id { get; init; }
        
    public required string Title { get; init; }

    public required string Description { get; init; }
}