using Contracts.Features.Cocktails.GetCocktail;
using Contracts.Features.Cocktails.GetCocktails;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

/// <summary>
///     Контроллер коктейлей
/// </summary>
[Route("api/cocktails")]
public sealed class CocktailsController : BaseController
{
    /// <summary>
    ///     Запрос на получение коктейлей
    /// </summary>
    /// <param name="dto">Данные поиска</param>
    /// <param name="cancellationToken">Токен отмены запроса</param>
    /// <returns>Коллекция коктейлей</returns>
    [HttpGet]
    public async Task<ActionResult<IEnumerable<GetCocktailsResponseDto>>> GetCocktailsAsync(
        [FromQuery] GetCocktailsRequestDto dto,
        CancellationToken cancellationToken)
    {
        return Ok(await Mediator.Send(new GetCocktailsRequest(dto), cancellationToken));
    }
    
    /// <summary>
    ///     Запрос на получение коктейля
    /// </summary>
    /// <param name="dto">Данные поиска</param>
    /// <param name="cancellationToken">Токен отмены запроса</param>
    /// <returns>Коктейль</returns>
    [HttpGet("{id:int}")]
    public async Task<ActionResult<GetCocktailResponseDto>> GetCocktailAsync(
        [FromRoute] GetCocktailRequestDto dto,
        CancellationToken cancellationToken)
    {
        return Ok(await Mediator.Send(new GetCocktailRequest(dto), cancellationToken));
    }
}