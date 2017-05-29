using FCamara.Domain.Entities;
using FCamara.Domain.ValueObjects;

namespace FCamara.Infra.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FCamara.Infra.Contexts.FCamaraDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FCamara.Infra.Contexts.FCamaraDataContext context)
        {
            context.Customers.AddOrUpdate(
                new Customer("Edison", new Email("edijs.britto@gmail.com"), new User("edison", "edison"))
            );
            context.Products.AddOrUpdate(
                new Product("Max Payne 3", "Jogo de acão Xbox 360", "maxpayne3.JPG", 32.65m),
                new Product("Grand Theft Auto V", " - Xbox 360 Jogo de acão Xbox 360", "GTA5.JPG", 120m),
                new Product("Minecraft", "Jogo de acão Xbox 360", "minicraft.jpg", 85.60m),
                new Product("Resident Evil 6", "Jogo de acão Xbox 360", "residentEvil6.jpg", 99.65m),
                new Product("Lego Marvel Vingadores", "Jogo de acão Xbox 360", "vingadores.jpg", 32.65m),
                new Product("Pro Evolution Soccer 2015", "Jogo de acão Xbox 360", "pes2015.jpg", 32.65m),
                new Product("Lego Jurassic World", "Jogo de acão Xbox 360", "pes2015.jpg", 32.65m),
                new Product("Metal Gear Solid V", "The Phantom Pain - Day One Edition Jogo de acão Xbox 360", "metalgear.jpg", 32.65m),
                new Product("Mortal Kombat Vs. Dc Universe", "Jogo de acão Xbox 360", "mortalcombat.jpg", 32.65m),
                new Product("Lego Batman 3", " (Versão em Português) - XBOX 360", "batman3.jpg", 32.65m),
                new Product("Watch Dogs", "Jogo de acão Xbox 360", "watchdogs.jpg", 32.65m),
                new Product("Metal Gear Rising", "Jogo de acão Xbox 360", "metalgearrising.jpg", 32.65m),
                new Product("Assassin'S Creed Iv", " Black Flag Limited Edition - Xbox 360", "assasinscreediv.jpg", 32.65m),
                new Product("Ultra Street Fighter IV", "Jogo de acão Xbox 360", "ultrastreetfighter.jpg", 32.65m),
                new Product("Lego Lord of The Rings", "Jogo de acão Xbox 360", "legolord.jpg", 32.65m)
            );
        }
    }
}
