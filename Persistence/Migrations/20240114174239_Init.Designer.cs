﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240114174239_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Cocktail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_cocktails");

                    b.ToTable("cocktails", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("3b493e1e-9c2d-49de-b6c5-da9240b4334a"),
                            Description = "Это крепкий кофейно-сливочный коктейль на водке",
                            Title = "Белый русский"
                        },
                        new
                        {
                            Id = new Guid("15cc9bde-4698-4786-b11f-b157527d01cd"),
                            Description = "Это один из самых популярных миксов: апельсиновый сок и водка. На выходе коктейль получается очень цитрусовым. Большое количество сока делает \"Отвёртку\" слабоалкогольной, но это не значит, что лонг совершенно безвреден: пара-тройка коктейлей и настоящая отвёртка уже будет выпадать из ваших рук.",
                            Title = "Отвёртка"
                        },
                        new
                        {
                            Id = new Guid("abeeff92-3660-4e5f-9fa3-6ff96d34ca23"),
                            Description = "Это крепкий горький коктейль на основе джина с добавлением биттера и красного вермута. Идеален как в качестве аперитива, так и дижестива. Один из самых популярных коктейлей в мире, потрясающе вкусный и гармоничный. ",
                            Title = "Негрони"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
