namespace Contracts.Features.Cocktails.GetCocktails;

public sealed class GetCocktailsResponseDto
{
    public required IReadOnlyCollection<CocktailDto> Data { get; init; }

    public int TotalCount => Data.Count;
    
    public sealed class CocktailDto
    {
        public required Guid Id { get; init; }
    
        public required string Title { get; init; }

        public required string Description { get; init; }
    }
}