using Contracts.Features.Cocktails.GetCocktails;
using Contracts.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Cocktails.GetCocktails;

file sealed class GetCocktailsHandler : IRequestHandler<GetCocktailsRequest, GetCocktailsResponseDto>
{
    private readonly IAppDbContext _context;

    public GetCocktailsHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<GetCocktailsResponseDto> Handle(
        GetCocktailsRequest request,
        CancellationToken cancellationToken)
    {
        var queryable = _context.Cocktails.AsNoTracking();

        if (!ReferenceEquals(request.Dto.SearchValue, default))
        {
            var searchValue = $"%{request.Dto.SearchValue}%";
            
            queryable = queryable
                .Where(c =>
                    EF.Functions.ILike(c.Title, searchValue)
                    ||
                    EF.Functions.ILike(c.Description, searchValue));
        }

        return new GetCocktailsResponseDto
        {
            Data = await queryable
                .Select(c => new GetCocktailsResponseDto.CocktailDto
                {
                    Id = c.Id,
                    Title = c.Title,
                    Description = c.Description
                })
                .ToListAsync(cancellationToken)
        };
    }
}