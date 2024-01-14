using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public sealed class CocktailConfiguration : IEntityTypeConfiguration<Cocktail>
{
    public void Configure(EntityTypeBuilder<Cocktail> builder)
    {
        builder.HasData(
            new Cocktail[]
            {
                new(
                    "Белый русский",
                    "Это крепкий кофейно-сливочный коктейль на водке"),
                new(
                    "Отвёртка",
                    "Это один из самых популярных миксов: апельсиновый сок и водка. На выходе коктейль получается очень цитрусовым. Большое количество сока делает \"Отвёртку\" слабоалкогольной, но это не значит, что лонг совершенно безвреден: пара-тройка коктейлей и настоящая отвёртка уже будет выпадать из ваших рук."),
                new Cocktail(
                    "Негрони",
                    "Это крепкий горький коктейль на основе джина с добавлением биттера и красного вермута. Идеален как в качестве аперитива, так и дижестива. Один из самых популярных коктейлей в мире, потрясающе вкусный и гармоничный. ")
            });
    }
}