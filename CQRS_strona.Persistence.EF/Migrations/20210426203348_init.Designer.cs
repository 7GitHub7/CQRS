﻿// <auto-generated />
using System;
using CQRS_strona.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CQRS_strona.Persistence.EF.Migrations
{
    [DbContext(typeof(CQRS_stronaContext))]
    [Migration("20210426203348_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CQRS_strona.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisplayName = "C#",
                            Name = "CSharp"
                        },
                        new
                        {
                            CategoryId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisplayName = "Triki z Windows",
                            Name = "triki-z-windows"
                        },
                        new
                        {
                            CategoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisplayName = "ASP.NET",
                            Name = "aspnet"
                        },
                        new
                        {
                            CategoryId = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisplayName = "Docker",
                            Name = "docker"
                        },
                        new
                        {
                            CategoryId = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DisplayName = "Filozofia",
                            Name = "filozofia"
                        });
                });

            modelBuilder.Entity("CQRS_strona.Domain.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PostId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            PostId = 1,
                            Author = "Damian",
                            CategoryId = 2,
                            Date = new DateTime(2020, 10, 26, 22, 33, 48, 185, DateTimeKind.Local).AddTicks(9132),
                            Description = "Nasze aplikacje ASP.NET CORE coraz częściej są tylko aplikacją REST. To oczywiście wymaga Walidacji po stronie klienta i po stronie serwera\r\nJak taką walidację jak najszybciej zrobić.Może przecież sam napisać takie warunki,\r\n                ale przy dużej ilości klas,\r\n                które występują jako parametry mija się to z celem.\r\n\r\nMożesz też skorzystać z atrybutów i oznaczyć reguły do każdej właściwości.",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 8,
                            Title = "Walidacja z FluentValidation w ASP.NET Core + Swagger",
                            Url = "https://cezarywalenciuk.pl/blog/programing/walidacja-z-fluentvalidation-waspnet-core--swagger"
                        },
                        new
                        {
                            PostId = 3,
                            Author = "Stefan",
                            CategoryId = 5,
                            Date = new DateTime(2020, 4, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9134),
                            Description = "W pod koniec roku 2017 zacząłem ćwiczyć. Proste ćwiczenia rzeczywiście robią różnice, gdy masz siedzący tryb życia. A co z bieganiem ?\r\nPamiętam jak pierwszy raz na bieżni nie byłem w stanie wytrzymać 5 minut normalnego spaceru. Powoli z tygodnia na dzień zacząłem sobie stawiać wyższe progi i tak odkryłem, że o ile jest to na początku bolesne to jak twoje ciało da Ci te endorfiny to już...aż chce się biegać więcej. ",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 5,
                            Title = "Bieganie jak się do tego zmotywować : Zdrowie Programisty",
                            Url = "https://cezarywalenciuk.pl/blog/programing/bieganie-jak-sie-do-tego-zmotywowac--zdrowie-programisty"
                        },
                        new
                        {
                            PostId = 2,
                            Author = "Damian",
                            CategoryId = 2,
                            Date = new DateTime(2020, 10, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9054),
                            Description = "Programiści codziennie tworzą jakąś aplikację sieciową typu REST. Teraz nastaje pytanie, jak najlepiej zrozumieć jak dane API działa. Do tego mamy dokumentacje, ale jeśli pracujesz w szybkich, zamkniętych projektach to takiej dokumentacji może nie być.",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 7,
                            Title = "Swagger UI : Dokumentowanie API w ASP.NET CORE",
                            Url = "https://cezarywalenciuk.pl/blog/programing/swagger-ui--dokumentowanie-api-w-aspnet-core"
                        },
                        new
                        {
                            PostId = 4,
                            Author = "Damian",
                            CategoryId = 2,
                            Date = new DateTime(2020, 4, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9141),
                            Description = "Logowanie działania aplikacji. Jak wiedzieć w końcu, gdy coś nie działa. Mój blog jest napisany w C# i działa po ASP.NET CORE. Jak to jednak bywa z napisaną przez siebie aplikacją pojawiają się błędy więc do bloga dodałem mechanizm logowania błędów. W taki sposób znalazłem wiele dziwnych przypadków uszkodzonych wpisów w formacie XML, które rozwalały Parser. Znalazłem też złe zbudowane przez ze mnie lista kursów. ",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 5,
                            Title = "NLog z ASP.NET Core : Logowanie błędów w aplikacji",
                            Url = "https://cezarywalenciuk.pl/blog/programing/nlog-z-aspnet-core--logowanie-b%C5%82edow-w-aplikacji"
                        },
                        new
                        {
                            PostId = 5,
                            Author = "Damian",
                            CategoryId = 2,
                            Date = new DateTime(2020, 4, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9146),
                            Description = "Logowanie działania aplikacji. Jak wiedzieć w końcu, gdy coś nie działa. Mój blog jest napisany w C# i działa po ASP.NET CORE. Jak to jednak bywa z napisaną przez siebie aplikacją pojawiają się błędy więc do bloga dodałem mechanizm logowania błędów. W taki sposób znalazłem wiele dziwnych przypadków uszkodzonych wpisów w formacie XML, które rozwalały Parser. Znalazłem też złe zbudowane przez ze mnie lista kursów. ",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 5,
                            Title = "NLog z ASP.NET Core : Logowanie błędów w aplikacji",
                            Url = "https://cezarywalenciuk.pl/blog/programing/nlog-z-aspnet-core--logowanie-b%C5%82edow-w-aplikacji"
                        },
                        new
                        {
                            PostId = 6,
                            Author = "Damian",
                            CategoryId = 2,
                            Date = new DateTime(2020, 8, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9150),
                            Description = "W tym  artykule zobaczymy jak zintegrować AutoMapper  z ASP.NET CORE dla .NET 5, chociaż bądźmy szczerzy możesz skorzystać z tej biblioteki w każdym projekcie w C#.",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 9,
                            Title = "AutoMapper z ASP.NET CORE czyli mapowanie klas",
                            Url = "https://cezarywalenciuk.pl/blog/programing/automapper-z-aspnet-core"
                        },
                        new
                        {
                            PostId = 8,
                            Author = "Adrian",
                            CategoryId = 3,
                            Date = new DateTime(2020, 1, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9159),
                            Description = "Jak jeszcze lepiej ulepszyć system operacyjny Windows.\r\n\r\nCzy być może programy tobie, które za chwilę to śmieci, które nie będą ci potrzebne?\r\n\r\nZazwyczaj w tym cyklu pokazuje programy, z które moim bardzo zmieniają przepływ mojej pracy.",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 5,
                            Title = "QuickLook, TeraCopy, ProcessExplorer czy to potrzebne jest ?",
                            Url = "https://cezarywalenciuk.pl/blog/programing/sharex-lepszy-printscreen-oraz-robienie-gif-ow"
                        },
                        new
                        {
                            PostId = 7,
                            Author = "Adrian",
                            CategoryId = 3,
                            Date = new DateTime(2020, 2, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9155),
                            Description = "Nagrywanie Gif - ów ? Robienie obrazków na bloga ? Jak to robić jeszcze szybciej ? ",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 4,
                            Title = "ShareX : Lepszy PrintScreen oraz robienie Gif-ów twojego pulpitu?",
                            Url = "https://cezarywalenciuk.pl/blog/programing/sharex-lepszy-printscreen-oraz-robienie-gif-ow"
                        },
                        new
                        {
                            PostId = 9,
                            Author = "Adrian",
                            CategoryId = 4,
                            Date = new DateTime(2020, 1, 26, 22, 33, 48, 187, DateTimeKind.Local).AddTicks(9163),
                            Description = "Jak jeszcze lepiej ulepszyć system operacyjny Windows.\r\n\r\nCzy być może programy tobie, które za chwilę to śmieci, które nie będą ci potrzebne?\r\n\r\nZazwyczaj w tym cyklu pokazuje programy, z które moim bardzo zmieniają przepływ mojej pracy.",
                            ImageUrl = "https://cezarywalenciuk.pl/Posts/programing/icons/_withbackground/R2/656_walidacja-z-fluentvalidation-waspnet-core--swagger.png",
                            Rate = 9,
                            Title = "Docker File dla Go, ASP.NET Core, .NET 5, Java Spring, NodeJS, Python",
                            Url = "https://cezarywalenciuk.pl/blog/programing/docker-file-dla-go-aspnet-core-net-5-java-spring-nodejs-python"
                        });
                });

            modelBuilder.Entity("CQRS_strona.Domain.Entities.Webinar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AlreadyHappend")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacebookEventUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlidesUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WatchFacebookLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WatchYoutubeLink")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Webinars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AlreadyHappend = false,
                            Date = new DateTime(2021, 5, 6, 22, 33, 48, 188, DateTimeKind.Local).AddTicks(6889),
                            Description = "Ustalenie architektury nie jest prostym zadaniem. Każda decyzja może mieć wielkie komplikacje potem.",
                            FacebookEventUrl = "https://www.facebook.com/events/407358067213893/",
                            ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/17_apliacjacsharpodzeraarchitekturacqrs.jpg",
                            SlidesUrl = "",
                            Title = "Aplikacja C# od Zera Architektura, CQRS, Dobre praktyki",
                            WatchFacebookLink = "",
                            WatchYoutubeLink = ""
                        },
                        new
                        {
                            Id = 2,
                            AlreadyHappend = false,
                            Date = new DateTime(2021, 3, 17, 22, 33, 48, 188, DateTimeKind.Local).AddTicks(8864),
                            Description = "Kontenery są tutaj. Kubernetes jest de facto platformą do ich uruchamiania i zarządzania.",
                            FacebookEventUrl = "https://www.facebook.com/events/407358067213893/",
                            ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/17_apliacjacsharpodzeraarchitekturacqrs.jpg",
                            SlidesUrl = "https://panniebieski.github.io/webinar-Kubernetes-Docker-Wytlumacz-mi-i-pokaz/",
                            Title = "Kubernetes i Docker : Wytłumacz mi i pokaż",
                            WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2775230679405348&ref=watch_permalink",
                            WatchYoutubeLink = "https://www.youtube.com/watch?v=7g00wOg9Jto"
                        },
                        new
                        {
                            Id = 3,
                            AlreadyHappend = false,
                            Date = new DateTime(2021, 2, 25, 22, 33, 48, 188, DateTimeKind.Local).AddTicks(8927),
                            Description = "Jak utworzyć projekt w .NET 5?",
                            FacebookEventUrl = "https://www.facebook.com/events/407358067213893/",
                            ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/15_csharpirekordy.jpg",
                            SlidesUrl = "https://panniebieski.github.io/webinar_CSharp9-Rekordy-i-duze-zamiany-w-net-5/",
                            Title = "C# 9, Rekordy i duże zmiany w .NET 5",
                            WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2835303250091399&ref=watch_permalink",
                            WatchYoutubeLink = "https://www.youtube.com/watch?v=ATbLEyd_1Kg"
                        },
                        new
                        {
                            Id = 4,
                            AlreadyHappend = false,
                            Date = new DateTime(2021, 2, 15, 22, 33, 48, 188, DateTimeKind.Local).AddTicks(8932),
                            Description = "Czasami jedyne czego potrzebujemy to dobrego przykładu.",
                            FacebookEventUrl = "https://www.facebook.com/events/407358067213893/",
                            ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/15_csharpirekordy.jpg",
                            SlidesUrl = "https://panniebieski.github.io/webinar_CSharp9-Rekordy-i-duze-zamiany-w-net-5/",
                            Title = "Szybki Trening Sql Server 2",
                            WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2835303250091399&ref=watch_permalink",
                            WatchYoutubeLink = "https://www.youtube.com/watch?v=ATbLEyd_1Kg"
                        },
                        new
                        {
                            Id = 5,
                            AlreadyHappend = false,
                            Date = new DateTime(2021, 1, 26, 22, 33, 48, 188, DateTimeKind.Local).AddTicks(8936),
                            Description = "Jak wygląda szukanie pracy jako programista w 2020 roku? Czy jest lepiej, czy jest gorzej?",
                            FacebookEventUrl = "https://www.facebook.com/events/407358067213893/",
                            ImageUrl = "https://cezarywalenciuk.pl/posts/fileswebinars/15_csharpirekordy.jpg",
                            SlidesUrl = "https://panniebieski.github.io/webinar_CSharp9-Rekordy-i-duze-zamiany-w-net-5/",
                            Title = "Pytania rekrutacyjne czyli dalsza kariera",
                            WatchFacebookLink = "https://www.facebook.com/watch/live/?v=2835303250091399&ref=watch_permalink",
                            WatchYoutubeLink = "https://www.youtube.com/watch?v=ATbLEyd_1Kg"
                        });
                });

            modelBuilder.Entity("CQRS_strona.Domain.Entities.Post", b =>
                {
                    b.HasOne("CQRS_strona.Domain.Entities.Category", "Category")
                        .WithMany("Posts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CQRS_strona.Domain.Entities.Category", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
