using MediatR;

namespace Contracts.Features.Cocktails.GetCocktails;

public sealed record GetCocktailsRequest(GetCocktailsRequestDto Dto) : IRequest<GetCocktailsResponseDto>;