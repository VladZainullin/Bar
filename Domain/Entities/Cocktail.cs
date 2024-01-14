namespace Domain.Entities;

/// <summary>
///     Коктейль
/// </summary>
public sealed class Cocktail
{
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    private Cocktail()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        
    }

    public Cocktail(string title, string description) : this()
    {
        Title = title;
        Description = description;
    }

    public Guid Id { get; private init; } = Guid.NewGuid();
    
    /// <summary>
    ///     Наименование коктейля
    /// </summary>
    public string Title { get; private init; }
    
    /// <summary>
    ///     Описание коктейля
    /// </summary>
    public string Description { get; private init; }
}