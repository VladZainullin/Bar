using MediatR;

namespace Contracts.Features.Cocktails.GetCocktail;

public sealed record GetCocktailRequest(GetCocktailRequestDto Dto) : IRequest<GetCocktailResponseDto>;